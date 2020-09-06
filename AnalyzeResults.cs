using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQR_Session5_3_9.Properties;

namespace TPQR_Session5_3_9
{
    public partial class AnalyzeResults : Form
    {
        Dictionary<string, double> bestCountry = new Dictionary<string, double>();
        public AnalyzeResults()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void AnalyzeResults_Load(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var getSkills = (from x in context.Skills
                                 select x.skillName).Distinct().ToArray();
                cbSkill.Items.AddRange(getSkills);
            }
        }

        private void cbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            bestCountry.Clear();
            lblBestCountry.Text = "Best Country";
            lblEasiest.Text = "Session No (Mark Range)";
            lblToughest.Text = "Session No (Mark Range)";
            lblMedian.Text = 0.ToString();
            pbGreenUp.Visible = true;
            pbRedDown.Visible = true;
            pbCountry.Image = null;
            chart1.Series.Clear();
            using (var context = new Session5Entities())
            {
                var getSkillID = (from x in context.Skills
                                  where x.skillName == cbSkill.SelectedItem.ToString()
                                  select x.skillId).FirstOrDefault();
                var getResults = (from x in context.Results
                                  where x.Competition.skillIdFK == getSkillID
                                  group x by x.Competitor.competitorCountry into y
                                  select y);
                foreach (var item in getResults)
                {
                    var listAverage = new List<double>();
                    var getCompetitors = (from x in context.Competitors
                                          where x.competitorCountry == item.Key
                                          select x);
                    foreach (var competitor in getCompetitors)
                    {
                        listAverage.Add(competitor.Results.Where(x => x.recordsIdFK == competitor.recordsId).Sum(x => x.totalMarks));
                    }
                    bestCountry.Add(item.Key, listAverage.Average());
                }

                if (bestCountry.Count != 0)
                {
                    var bestPerformingCountry = bestCountry.OrderByDescending(x => x.Value).ElementAt(0).Key;
                    pbCountry.Image = ReturnFlag(bestPerformingCountry);
                    lblBestCountry.Text = $"{bestPerformingCountry} ({bestCountry.OrderByDescending(x => x.Value).ElementAt(0).Value})";
                    var getBestSession = (from x in context.Results
                                          where x.Competition.skillIdFK == getSkillID
                                          group x.totalMarks by x.Competition.sessionNo into y
                                          select new { minVale = y.Min(), maxValue = y.Max(), SessionNo = y.Key });
                    var sessionDictMin = new Dictionary<int, double>();
                    var sessionDictMax = new Dictionary<int, double>();
                    foreach (var item in getBestSession)
                    {
                        sessionDictMin.Add(item.SessionNo, item.minVale);
                        sessionDictMax.Add(item.SessionNo, item.maxValue);
                    }
                    var getEasiestSession = sessionDictMax.Where(x => x.Key == sessionDictMin.Where(y => y.Value == sessionDictMin.Values.Max()).Select(y => y.Key).FirstOrDefault()).Select(x => x.Key).FirstOrDefault(); ;
                    var getThoughestSession = sessionDictMin.Where(x => x.Key == sessionDictMax.Where(y => y.Value == sessionDictMax.Values.Min()).Select(y => y.Key).FirstOrDefault()).Select(x => x.Key).FirstOrDefault();
                    lblEasiest.Text = $"Session {getEasiestSession} ({sessionDictMin.Where(x => x.Key == getEasiestSession).Select(x => x.Value).FirstOrDefault()}-{sessionDictMax.Where(x => x.Key == getEasiestSession).Select(x => x.Value).FirstOrDefault()})";
                    lblToughest.Text = $"Session {getThoughestSession} ({sessionDictMin.Where(x => x.Key == getThoughestSession).Select(x => x.Value).FirstOrDefault()}-{sessionDictMax.Where(x => x.Key == getThoughestSession).Select(x => x.Value).FirstOrDefault()})";

                    var getResultsTotal = (from x in context.Results
                                           where x.Competitor.Skill.skillName == cbSkill.SelectedItem.ToString()
                                           orderby x.totalMarks
                                           select x.totalMarks).Count();

                    var median = (from x in context.Results
                                  where x.Competitor.Skill.skillName == cbSkill.SelectedItem.ToString()
                                  orderby x.totalMarks
                                  select x.totalMarks).ToList();

                    double getMedian = 0;

                    if (getResultsTotal % 2 != 0)
                    {
                        var midpoint = (getResultsTotal / 2);
                        getMedian = median[midpoint];
                    }
                    else
                    {
                        var midpoint1 = (getResultsTotal / 2) - 1;
                        var midpoint2 = (getResultsTotal / 2);
                        var medianResult = (median[midpoint1] + median[midpoint2]) / 2;
                        getMedian = Math.Round(medianResult, 1);
                    }


                    lblMedian.Text = $"{getMedian}";

                    var getSkillMedian = (from x in context.Skills
                                          where x.skillName == cbSkill.SelectedItem.ToString()
                                          select x.expectedMedianMark).FirstOrDefault();

                    if (getMedian > getSkillMedian)
                    {
                        pbRedDown.Visible = false;
                    }
                    else
                    {
                        pbGreenUp.Visible = false;
                    }

                    var getCompetitors = (from x in context.Competitors
                                          where x.skillIdFK == getSkillID
                                          select x);
                    foreach (var item in getCompetitors)
                    {
                        chart1.Series.Add(item.competitorName);
                        chart1.Series[item.competitorName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series[item.competitorName].BorderWidth = 3;
                        var getSessions = (from x in context.Competitions
                                           where x.skillIdFK == getSkillID
                                           orderby x.sessionNo
                                           select x.sessionNo);
                        foreach (var session in getSessions)
                        {
                            var getMarks = (from x in context.Results
                                            where x.Competition.sessionNo == session && x.recordsIdFK == item.recordsId && x.Competition.skillIdFK == getSkillID
                                            select x).FirstOrDefault();
                            if (getMarks != null)
                            {
                                chart1.Series[item.competitorName].Points.AddXY($"Session {session}", getMarks.totalMarks);
                            }
                            else
                            {
                                chart1.Series[item.competitorName].Points.AddXY($"Session {session}", 0);
                                
                            }
                        }
                    }
                }

            }
        }

        Bitmap ReturnFlag(string countryName)
        {
            switch (countryName.Trim().ToLower())
            {
                case "brunei":
                    return Resources.brunei_flag;
                case "australia":
                    return Resources.australia_flg;
                case "china":
                    return Resources.chinaflag;
                case "cambodia":
                    return Resources.flag_cambodia;
                case "russia":
                    return Resources.flag_russia;
                case "malaysia":
                    return Resources.flagmalaysia;
                case "india":
                    return Resources.flg_india;
                case "philippine":
                    return Resources.flg_philippine1;
                case "qatar":
                    return Resources.flg_qatar;
                case "thailand":
                    return Resources.flg_thailand;
                case "vietnam":
                    return Resources.flg_vietnam_new;
                case "indonesia":
                    return Resources.indonesia2;
                case "laos":
                    return Resources.laos_newflg;
                case "maldives":
                    return Resources.maldivesfg;
                case "myanmar":
                    return Resources.myanmar3;
                case "newzealand":
                    return Resources.newzealand_flg5;
                case "greece":
                    return Resources.old_greece;
                case "singapore":
                    return Resources.singapore_flag1;
                case "southkorea":
                    return Resources.southkorea_flag_new;
                case "switzerland":
                    return Resources.switzerland_old;
                default:
                    return null;
            }
        }
    }
}

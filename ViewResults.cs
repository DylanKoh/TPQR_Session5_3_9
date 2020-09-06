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
    public partial class ViewResults : Form
    {
        Dictionary<string, double> moreGold = new Dictionary<string, double>();
        Dictionary<string, double> moreSilver = new Dictionary<string, double>();
        Dictionary<string, double> moreBronze = new Dictionary<string, double>();
        public ViewResults()
        {
            InitializeComponent();
        }

        private void ViewResults_Load(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var getSkills = (from x in context.Skills
                                 select x.skillName).Distinct().ToArray();
                cbSkill.Items.AddRange(getSkills);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void cbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            moreGold.Clear();
            moreSilver.Clear();
            moreBronze.Clear();
            dataGridView1.Rows.Clear();
            pbGold1.Image = null;
            pbGold2.Image = null;
            pbSilver1.Image = null;
            pbSilver2.Image = null;
            pbBronze1.Image = null;
            pbBronze2.Image = null;
            using (var context = new Session5Entities())
            {
                var getSkillID = (from x in context.Skills
                                  where x.skillName == cbSkill.SelectedItem.ToString()
                                  select x.skillId).FirstOrDefault();
                var getResults = (from x in context.Results
                                  where x.Competition.skillIdFK == getSkillID
                                  group x by x.Competitor.competitorName into y
                                  orderby y.Sum(z => z.totalMarks) descending
                                  select y);
                foreach (var item in getResults)
                {
                    var newRow = new List<string>()
                    {
                        item.Key, item.Where(x => x.Competitor.competitorName == item.Key).Select(x => x.Competitor.competitorCountry).FirstOrDefault(),
                        item.Where(x => x.Competitor.competitorName == item.Key).Sum(x => x.totalMarks).ToString()
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                var getSessionTotal = Convert.ToDouble((from x in context.Competitions
                                                        where x.skillIdFK == getSkillID
                                                        select x).Sum(x => x.q1MaxMarks + x.q2MaxMarks + x.q3MaxMarks + x.q4MaxMarks));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    var getTotalMarks = Convert.ToDouble(dataGridView1[2, row.Index].Value);
                    if (getTotalMarks >= getSessionTotal * 0.80)
                    {
                        if (moreGold.Count == 0)
                        {
                            pbGold1.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                            moreGold.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                        }
                        else if (moreGold.Count == 1 && moreGold.ElementAt(0).Value - getTotalMarks <= 2 * moreGold.Count)
                        {
                            pbGold2.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                            moreGold.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                        }
                        else if (moreGold.Count == 2 && moreGold.ElementAt(0).Value - getTotalMarks <= 2 * moreGold.Count)
                        {
                            moreGold.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                        }
                        else
                        {
                            if (getTotalMarks >= getSessionTotal * 0.75)
                            {
                                if (moreSilver.Count == 0)
                                {
                                    pbSilver1.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                                    moreSilver.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                                }
                                else if (moreSilver.Count == 1 && moreSilver.ElementAt(0).Value - getTotalMarks <= 2 * moreSilver.Count)
                                {
                                    pbSilver2.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                                    moreSilver.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                                }
                                else if (moreSilver.Count == 2 && moreSilver.ElementAt(0).Value - getTotalMarks <= 2 * moreSilver.Count)
                                {
                                    moreSilver.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                                }
                                else
                                {
                                    if (getTotalMarks >= getSessionTotal * 0.71)
                                    {
                                        if (moreBronze.Count == 0)
                                        {
                                            pbBronze1.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                                            moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                                        }
                                        else if (moreBronze.Count == 1 && moreBronze.ElementAt(0).Value - getTotalMarks <= 2 * moreBronze.Count)
                                        {
                                            pbBronze2.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                                            moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                                        }
                                        else if (moreBronze.Count == 2 && moreBronze.ElementAt(0).Value - getTotalMarks <= 2 * moreBronze.Count)
                                        {
                                            moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), getTotalMarks);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (getTotalMarks >= getSessionTotal * 0.75)
                    {
                        if (moreSilver.Count == 0)
                        {
                            pbSilver1.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                            moreSilver.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                        }
                        else if (moreSilver.Count == 1 && moreSilver.ElementAt(0).Value - getSessionTotal <= 2 * moreSilver.Count)
                        {
                            pbSilver2.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                            moreSilver.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                        }
                        else if (moreSilver.Count == 2 && moreSilver.ElementAt(0).Value - getSessionTotal <= 2 * moreSilver.Count)
                        {
                            moreSilver.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                        }
                        else
                        {
                            if (getTotalMarks >= getSessionTotal * 0.71)
                            {
                                if (moreBronze.Count == 0)
                                {
                                    pbBronze1.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                                    moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                                }
                                else if (moreBronze.Count == 1 && moreBronze.ElementAt(0).Value - getSessionTotal <= 2 * moreBronze.Count)
                                {
                                    pbBronze2.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                                    moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                                }
                                else if (moreBronze.Count == 2 && moreBronze.ElementAt(0).Value - getSessionTotal <= 2 * moreBronze.Count)
                                {
                                    moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                                }
                            }
                        }
                    }
                    else if (getTotalMarks >= getSessionTotal * 0.71)
                    {
                        if (moreBronze.Count == 0)
                        {
                            pbBronze1.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                            moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                        }
                        else if (moreBronze.Count == 1 && moreBronze.ElementAt(0).Value - getSessionTotal <= 2 * moreBronze.Count)
                        {
                            pbBronze2.Image = ReturnFlag(dataGridView1[1, row.Index].Value.ToString());
                            moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
                        }
                        else if (moreBronze.Count == 2 && moreBronze.ElementAt(0).Value - getSessionTotal <= 2 * moreBronze.Count)
                        {
                            moreBronze.Add(dataGridView1[1, row.Index].Value.ToString(), Convert.ToInt32(dataGridView1[2, row.Index].Value));
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

        private void btnGold_Click(object sender, EventArgs e)
        {

        }

        private void btnSilver_Click(object sender, EventArgs e)
        {

        }

        private void btnBronze_Click(object sender, EventArgs e)
        {

        }
    }

}

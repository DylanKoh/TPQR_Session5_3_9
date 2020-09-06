using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_3_9
{
    public partial class CalculateBonus : Form
    {
        int skillID = 0;
        public CalculateBonus()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void CalculateBonus_Load(object sender, EventArgs e)
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
            cbCompetitor.Items.Clear();
            using (var context = new Session5Entities())
            {
                skillID = (from x in context.Skills
                           where x.skillName == cbSkill.SelectedItem.ToString()
                           select x.skillId).FirstOrDefault();
                var competitors = (from x in context.Competitors
                                   where x.skillIdFK == skillID
                                   select x.competitorName).ToArray();
                cbCompetitor.Items.AddRange(competitors);
            }
        }

        private void cbCompetitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new Session5Entities())
            {
                var getResults = (from x in context.Results
                                  where x.Competitor.competitorName == cbCompetitor.SelectedItem.ToString() && x.Competitor.skillIdFK == skillID
                                  orderby x.Competition.sessionNo
                                  select x);

                var bonus = 0;
                var totalAmount = 0;
                foreach (var item in getResults)
                {
                    double totalMark = item.Competition.q1MaxMarks + item.Competition.q2MaxMarks + item.Competition.q3MaxMarks + item.Competition.q4MaxMarks;
                    double q1Worth = item.Competition.q1MaxMarks / totalMark * 100;
                    double q2Worth = item.Competition.q2MaxMarks / totalMark * 100;
                    double q3Worth = item.Competition.q3MaxMarks / totalMark * 100;
                    double q4Worth = item.Competition.q4MaxMarks / totalMark * 100;
                    if (item.Competition.q3MaxMarks == 0)
                    {
                        var q1Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 1",
                            item.q1Marks.ToString(), item.Competition.q1MaxMarks.ToString(),
                            Math.Round(item.q1Marks/item.Competition.q1MaxMarks * q1Worth, 2).ToString()
                        };
                        var q2Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 2",
                            item.q2Marks.ToString(), item.Competition.q2MaxMarks.ToString(),
                            Math.Round(item.q2Marks/item.Competition.q2MaxMarks * q2Worth, 2).ToString()
                        };
                        dataGridView1.Rows.Add(q1Row.ToArray());
                        dataGridView1.Rows.Add(q2Row.ToArray());
                    }
                    else if (item.Competition.q4MaxMarks == 0)
                    {
                        var q1Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 1",
                            item.q1Marks.ToString(), item.Competition.q1MaxMarks.ToString(),
                            Math.Round(item.q1Marks/item.Competition.q1MaxMarks * q1Worth,2).ToString()
                        };
                        var q2Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 2",
                            item.q2Marks.ToString(), item.Competition.q2MaxMarks.ToString(),
                            Math.Round(item.q2Marks/item.Competition.q2MaxMarks * q2Worth, 2).ToString()
                        }; var q3Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 3",
                            item.q3Marks.ToString(), item.Competition.q3MaxMarks.ToString(),
                            Math.Round(item.q3Marks/item.Competition.q3MaxMarks * q3Worth,2).ToString()
                        };
                        dataGridView1.Rows.Add(q1Row.ToArray());
                        dataGridView1.Rows.Add(q2Row.ToArray());
                        dataGridView1.Rows.Add(q3Row.ToArray());
                    }
                    else
                    {
                        var q1Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 1",
                            item.q1Marks.ToString(), item.Competition.q1MaxMarks.ToString(),
                            Math.Round(item.q1Marks/item.Competition.q1MaxMarks * q1Worth,2).ToString()
                        };
                        var q2Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 2",
                            item.q2Marks.ToString(), item.Competition.q2MaxMarks.ToString(),
                            Math.Round(item.q2Marks/item.Competition.q2MaxMarks * q2Worth,2).ToString()
                        };
                        var q3Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 3",
                            item.q3Marks.ToString(), item.Competition.q3MaxMarks.ToString(),
                            Math.Round(item.q3Marks/item.Competition.q3MaxMarks * q3Worth,2).ToString()
                        };
                        var q4Row = new List<string>()
                        {
                            item.Competition.sessionNo.ToString(), "Question 4",
                            item.q4Marks.ToString(), item.Competition.q4MaxMarks.ToString(),
                            Math.Round(item.q4Marks/item.Competition.q4MaxMarks * q4Worth,2).ToString()
                        };
                        dataGridView1.Rows.Add(q1Row.ToArray());
                        dataGridView1.Rows.Add(q2Row.ToArray());
                        dataGridView1.Rows.Add(q3Row.ToArray());
                        dataGridView1.Rows.Add(q4Row.ToArray());
                    }
                }
            }
        }
    }
}

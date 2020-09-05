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
    public partial class EnterMarks : Form
    {
        List<decimal> list = new List<decimal>();

        public EnterMarks()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void EnterMarks_Load(object sender, EventArgs e)
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
            cbSession.Items.Clear();
            cbCompetitor.Items.Clear();
            using (var context = new Session5Entities())
            {
                var skillID = (from x in context.Skills
                               where x.skillName == cbSkill.SelectedItem.ToString()
                               select x.skillId).FirstOrDefault();
                var getSessions = (from x in context.Competitions
                                   where x.skillIdFK == skillID
                                   select x.sessionNo);
                foreach (var item in getSessions)
                {
                    cbSession.Items.Add(item);
                }

                var getCompetitors = (from x in context.Competitors
                                      where x.skillIdFK == skillID
                                      select x.competitorName).ToArray();
                cbCompetitor.Items.AddRange(getCompetitors);
            }
        }

        private void cbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCompetitor.SelectedItem == null)
            {
                MessageBox.Show("Please ensure that you remember to select a competitor!", "Enter Marks",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadDGV();
            }
        }

        private void cbCompetitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSession.SelectedItem == null)
            {
                MessageBox.Show("Please ensure that you remember to select a session!", "Enter Marks",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadDGV();
            }
        }

        private void LoadDGV()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Question";
            DataGridViewComboBoxColumn c = new DataGridViewComboBoxColumn();
            c.Name = "Grade";
            c.Items.Add("Gd");
            c.Items.Add("Avr");
            c.Items.Add("Pr");
            dataGridView1.Columns.Add(c);
            var list = new List<string>()
            {
                "TMarks", "Marks"
            };
            foreach (var item in list)
            {
                dataGridView1.Columns.Add(item, item);
            }
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            using (var context = new Session5Entities())
            {
                var sessionNo = Convert.ToInt32(cbSession.SelectedItem);
                var getQuestions = (from x in context.Competitions
                                    where x.Skill.skillName == cbSkill.SelectedItem.ToString() && x.sessionNo == sessionNo
                                    select x).First();

                var dict = new Dictionary<string, int>();
                dict.Add("Question 1", getQuestions.q1MaxMarks);
                dict.Add("Question 2", getQuestions.q2MaxMarks);
                dict.Add("Question 3", getQuestions.q3MaxMarks);
                dict.Add("Question 4", getQuestions.q4MaxMarks);
                foreach (var item in dict)
                {
                    if (item.Value == 0) continue;
                    else
                    {
                        List<string> rows = new List<string>()
                        {
                            item.Key, "", item.Value.ToString(), ""
                        };
                        dataGridView1.Rows.Add(rows.ToArray());
                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim() == "Gd")
                {
                    var marks = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = marks;
                    list.Add(Convert.ToDecimal(marks));
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim() == "Avr")
                {
                    var marks = Math.Round(Convert.ToDecimal(Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value) * 0.65), 1);
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = marks;
                    list.Add(Convert.ToDecimal(marks));

                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim() == "Pr")
                {
                    var marks = Math.Round(Convert.ToDecimal(Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value) * 0.2), 1);
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = marks;
                    list.Add(Convert.ToDecimal(marks));
                }

                var total = list.Sum();
                lblTotalMarks.Text = total.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[1].Value = "";
                item.Cells[3].Value = "";
            }
            lblTotalMarks.Text = "Total Marks: ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var getCompetitor = (from x in context.Competitors
                                     where x.competitorName == cbCompetitor.SelectedItem.ToString()
                                     select x.recordsId).FirstOrDefault();
                var getSkillID = (from x in context.Skills
                                  where x.skillName == cbSkill.SelectedItem.ToString()
                                  select x.skillId).First();
                var sessionNo = Convert.ToInt32(cbSession.SelectedItem);
                var getCompetitionID = (from x in context.Competitions
                                        where x.skillIdFK == getSkillID && x.sessionNo == sessionNo
                                        select x.competitionId).First();
                var checkIfResults = (from x in context.Results
                                      where x.recordsIdFK == getCompetitor && x.competitionIdFK == getCompetitionID
                                      select x).FirstOrDefault();

                var marks = new List<decimal>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    marks.Add(Math.Round(Convert.ToDecimal(item.Cells[3].Value), 1));
                }
                var total = marks.Sum();

                if (checkIfResults != null)
                {
                    if (marks.Count() == 4)
                    {

                        checkIfResults.competitionIdFK = getCompetitionID;
                        checkIfResults.recordsIdFK = getCompetitor;
                        checkIfResults.q1Marks = Convert.ToDouble(marks[0]);
                        checkIfResults.q2Marks = Convert.ToDouble(marks[1]);
                        checkIfResults.q3Marks = Convert.ToDouble(marks[2]);
                        checkIfResults.q4Marks = Convert.ToDouble(marks[3]);
                        checkIfResults.totalMarks = Convert.ToDouble(total);

                    }
                    else if (marks.Count() == 3)
                    {
                        checkIfResults.competitionIdFK = getCompetitionID;
                        checkIfResults.recordsIdFK = getCompetitor;
                        checkIfResults.q1Marks = Convert.ToDouble(marks[0]);
                        checkIfResults.q2Marks = Convert.ToDouble(marks[1]);
                        checkIfResults.q3Marks = Convert.ToDouble(marks[2]);
                        checkIfResults.q4Marks = 0;
                        checkIfResults.totalMarks = Convert.ToDouble(total);
                    }
                    else
                    {
                        checkIfResults.competitionIdFK = getCompetitionID;
                        checkIfResults.recordsIdFK = getCompetitor;
                        checkIfResults.q1Marks = Convert.ToDouble(marks[0]);
                        checkIfResults.q2Marks = Convert.ToDouble(marks[1]);
                        checkIfResults.q3Marks = 0;
                        checkIfResults.q4Marks = 0;
                        checkIfResults.totalMarks = Convert.ToDouble(total);
                    }
                }

                //If not, then add to DB
                else
                {
                    if (marks.Count() == 4)
                    {
                        context.Results.Add(new Result()
                        {
                            competitionIdFK = getCompetitionID,
                            recordsIdFK = getCompetitor,
                            q1Marks = Convert.ToDouble(marks[0]),
                            q2Marks = Convert.ToDouble(marks[1]),
                            q3Marks = Convert.ToDouble(marks[2]),
                            q4Marks = Convert.ToDouble(marks[3]),
                            totalMarks = Convert.ToDouble(total)
                        });
                    }
                    else if (marks.Count() == 3)
                    {
                        context.Results.Add(new Result()
                        {
                            competitionIdFK = getCompetitionID,
                            recordsIdFK = getCompetitor,
                            q1Marks = Convert.ToDouble(marks[0]),
                            q2Marks = Convert.ToDouble(marks[1]),
                            q3Marks = Convert.ToDouble(marks[2]),
                            q4Marks = 0,
                            totalMarks = Convert.ToDouble(total)
                        });
                    }
                    else
                    {
                        context.Results.Add(new Result()
                        {
                            competitionIdFK = getCompetitionID,
                            recordsIdFK = getCompetitor,
                            q1Marks = Convert.ToDouble(marks[0]),
                            q2Marks = Convert.ToDouble(marks[1]),
                            q3Marks = 0,
                            q4Marks = 0,
                            totalMarks = Convert.ToDouble(total)
                        });
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Entered marks successfully!", "Enter Marks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                (new AdminMain()).ShowDialog();
                this.Close();
            }
        }
    }
}


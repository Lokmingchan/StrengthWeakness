using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pokemon.BusinessLayer;

namespace Pokemon
{
    public partial class StrengthWeakness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSubmit.Click += btnSubmit_OnClick;
            btnReset.Click += btnReset_OnClick;

            if (!IsPostBack)
            {
                Elements eleTypes = new Elements();
                PopulateDropDowns(eleTypes);
            }
        }

        private void PopulateDropDowns(Elements eleTypes)
        {
            ddlAttackType.Items.Add("No Selection");
            ddlDefenseType1.Items.Add("No Selection");
            ddlDefenseType2.Items.Add("No Selection");

            foreach (Element e in eleTypes.PokemonElements)
            {
                if (e.ElementName == "MissingNo")
                    continue;
                ddlAttackType.Items.Add(e.ElementName);
                ddlDefenseType1.Items.Add(e.ElementName);
                ddlDefenseType2.Items.Add(e.ElementName);
            }

        }

        public double GetDamage(Element e, int DefendType1, int DefendType2)
        {
            return e.GetDamage(DefendType1) * e.GetDamage(DefendType2);
        }

        public Dictionary<string, double> GetDefendingTypes(Elements eleTypes, Element e)
        {
            Dictionary<string, double> temp = new Dictionary<string,double>();

            for (int x = 1; x <= 18; x++)
            {
                if(e.GetDamage(x) != 1){
                    temp.Add(eleTypes.PokemonElements[x].ElementName, e.GetDamage(x));
                }
            }

            return temp;
        }

        public Dictionary<string, double> GetAttackingTypes(Elements eleTypes, int DefendingType1, int DefendingType2)
        {
            Dictionary<string, double> temp = new Dictionary<string, double>();

            for (int x = 1; x <= 18; x++)
            {
                if (eleTypes.PokemonElements[x].GetDamage(DefendingType1) * eleTypes.PokemonElements[x].GetDamage(DefendingType2) != 1)
                {
                    temp.Add(eleTypes.PokemonElements[x].ElementName, eleTypes.PokemonElements[x].GetDamage(DefendingType1) * eleTypes.PokemonElements[x].GetDamage(DefendingType2));
                }
            }

            return temp;
        }

        private void btnSubmit_OnClick(object sender, EventArgs e)
        {
            Elements eleTypes = new Elements();

            lblDisplay.Text = "";

            if (ddlAttackType.SelectedIndex != 0)
            {
                if (ddlDefenseType1.SelectedIndex != 0 | ddlDefenseType2.SelectedIndex != 0)
                {
                    lblDisplay.Text += "Attacking Pokemon Move: <b>" + ddlAttackType.SelectedValue + "</b> vs Defending Pokemon Type(s): <b>";
                    if (ddlDefenseType1.SelectedIndex > 0)
                    {
                        lblDisplay.Text += ddlDefenseType1.SelectedValue;
                        if (ddlDefenseType2.SelectedIndex > 0)
                        {
                            lblDisplay.Text += "/" + ddlDefenseType2.SelectedValue;
                        }
                    }
                    else if (ddlDefenseType2.SelectedIndex > 0)
                    {
                        lblDisplay.Text += ddlDefenseType2.SelectedValue;
                    }
                    lblDisplay.Text += "</b>";
                    lblDisplay.Text += "<br /><br />";
                    lblDisplay.Text += "Damage: " + GetDamage(eleTypes.PokemonElements[ddlAttackType.SelectedIndex], ddlDefenseType1.SelectedIndex, ddlDefenseType2.SelectedIndex).ToString() + "x";
                }
                else
                {
                    Dictionary<string, double> DisplayTypes = GetDefendingTypes(eleTypes, eleTypes.PokemonElements[ddlAttackType.SelectedIndex]);
                    lblDisplay.Text += "<u>Attacking Pokemon Move: <b>" + ddlAttackType.SelectedValue + "</b></u>";
                    lblDisplay.Text += "<br /><br />";

                    lblDisplay.Text += "<u>Defending Pokemon Types</u>";
                    lblDisplay.Text += "<br /><br />";

                    lblDisplay.Text += "<b>Mega Effective (4x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == 4)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Super Effective (2x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == 2)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Not Very Effective (.5x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == .5)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Really Not Very Effective (.25x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == .25)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Damage Not Effective At All (0x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == 0)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                }
            }
            else 
            {
                if (ddlDefenseType1.SelectedIndex != 0 | ddlDefenseType2.SelectedIndex != 0)
                {
                    Dictionary<string, double> DisplayTypes = GetAttackingTypes(eleTypes, ddlDefenseType1.SelectedIndex, ddlDefenseType2.SelectedIndex);
                    lblDisplay.Text += "<u>Attacking Pokemon Moves</u>";
                    lblDisplay.Text += "<br /><br />";

                    lblDisplay.Text += "<b>Mega Effective (4x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == 4)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Super Effective (2x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == 2)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Not Very Effective (.5x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == .5)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Really Not Very Effective (.25x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == .25)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }
                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<b>Damage Not Effective At All (0x)</b>";
                    lblDisplay.Text += "<br />";
                    foreach (KeyValuePair<string, double> kvp in DisplayTypes)
                    {
                        if (kvp.Value == 0)
                        {
                            lblDisplay.Text += kvp.Key + ": " + kvp.Value;
                            lblDisplay.Text += "<br />";
                        }
                    }

                    lblDisplay.Text += "<br />";
                    lblDisplay.Text += "<u>Defending Pokemon Type: <b>";
                    if (ddlDefenseType1.SelectedIndex > 0)
                    {
                        lblDisplay.Text += ddlDefenseType1.SelectedValue;
                        if (ddlDefenseType2.SelectedIndex > 0)
                        {
                            lblDisplay.Text += "/" + ddlDefenseType2.SelectedValue;
                        }
                    }
                    else if (ddlDefenseType2.SelectedIndex > 0)
                    {
                        lblDisplay.Text += ddlDefenseType2.SelectedValue;
                    }
                     
                    lblDisplay.Text += "</b></u>";
                    lblDisplay.Text += "<br /><br />";
                }
            }
        }

        private void btnReset_OnClick(object sender, EventArgs e)
        {
            ddlAttackType.SelectedIndex = 0;
            ddlDefenseType1.SelectedIndex = 0;
            ddlDefenseType2.SelectedIndex = 0;
        }
    }
}
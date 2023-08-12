using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareMajorProject
{
    public partial class EndUserLicenceAgreementPage : Form
    {
        string userNameLoggedIn;

        public EndUserLicenceAgreementPage(string userName)
        {
            userNameLoggedIn = userName;
            InitializeComponent();
        }

        private void EndUserLicenceAgreementPage_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = noterDatabase.db";

            string cmd = "SELECT * FROM 'NoterSettings'";
            SQLiteDataAdapter settingsDataAdapter = new SQLiteDataAdapter(cmd, sqlConnection);

            var dataTableSettings = new DataTable();

            sqlConnection.Open();
            settingsDataAdapter.Fill(dataTableSettings);
            sqlConnection.Close();

            foreach (DataRow row in dataTableSettings.Rows)
            {
                if (row[0].ToString() == userNameLoggedIn)
                {
                    //Background colour
                    BackColor = Color.FromName(row[1].ToString());

                    //Font type
                    Font userFontTextBox = new Font(row[3].ToString(), 10);
                    Font userFontBackButton = new Font(row[3].ToString(), 12);
                    txtEndUserLicenceAgreement.Font = userFontTextBox;
                    BtnBack.Font = userFontBackButton;
                }
            }

            txtEndUserLicenceAgreement.Text = "End-User License Agreement for Noter\r\nLast updated: 4/08/2023\r\nThis End-User License Agreement (referred to as the \"EULA\") is a legally binding agreement between you, the Licensee, an individual customer or entity, and the Noter, the company, and the author of Noter, the Software, which may include associated media, printed materials, and online or electronic documentation. This Agreement is a legally binding contract that includes terms that limit your legal rights and Licensors' liability to you, and shall govern all access to and use of this Software. You hereby agree, without limitation or alteration, to all the terms and conditions contained herein.\r\nBy installing, copying, or otherwise using the Licensed Product (Software), the Licensee agrees to be bound by the terms and conditions outlined in this EULA. However, if the Licensee does not agree to the terms and conditions outlined in this EULA, the said Licensee may not download, install, or use Software.\r\n\r\nDefinitions\r\n\"EULA\" shall refer to this End-User-License-Agreement, including any amendment to this Agreement.\r\n\"Licensee\" shall refer to the individual or entity that downloads and uses the Software.\r\n\"Licensor\" shall refer to the company or author, Noter. \r\n\"Software/Licensed product\" shall mean Noter, the Licensed Product provided pursuant to this EULA.\r\n\r\nGrant of License\r\nSubject to the terms of this EULA, the Noter hereby grants to the Licensee, a royalty-free, revocable, limited, non-exclusive license during the term of this EULA to possess and to use a copy of the Software. The Software is being distributed by Noter. Licensee is not allowed to make a charge for distributing this Software, either for profit or merely to recover media and distribution costs.\r\n\r\nIntellectual Property\r\nYou hereby unconditionally agree that all right, title and interest in the copyrights and other intellectual property rights in the Licensed Product reside with the Licensors. The trademarks, logos, designs, and service marks appearing on the Licensed Product are registered and unregistered marks of Licensor.  Accordingly, nothing in this EULA or the Licensed Product grants you any right to use any form of intellectual property contained in the Licensed Product.\r\nTherefore, all rights, titles, interests, and copyrights in and/or to the Software, including but not limited to all images, graphics, animations, audio, video, music, text, data, code, algorithm, and information, are owned by the Licensor. Accordingly, the Software is protected by all applicable copyright laws and international treaties, and the Licensee is expected to use the Software concerning all intellectual property contained therein, except as otherwise provided for in this EULA.\r\n\r\nDescription of Rights and Limitations\r\nInstallation and Use: Licensee may install and use the Software on a shared computer or concurrently on different computers, and make multiple back-up copies of the Software, solely for Licensee's use within Licensee's business or personal use.\r\n\r\nReproduction and Distribution:  Licensee may not duplicate or re-distribute copies of the Software, without the Licensors express written permission. \r\n\r\nLicensee Limitation: The Licensee may not:\r\nUse the Licensed Product for any purpose other than personal and non-commercial purposes;\r\nUse the Licensed Product for any illegal or unlawful purpose;\r\nGather factual content or any other portion of the Licensed product by any automated means, including but not limited to database scraping or screen scraping; or\r\nReverse engineer, decompile, or disassemble Software, except and only to the extent that such activity is expressly permitted by applicable law notwithstanding the limitation.\r\n\r\nUpdate and Maintenance\r\nNoter shall provide updates and maintenance on an as-needed basis.\r\n\r\nSupport\r\nNoter has no obligation to Software support, or to continue providing or updating any of the Software.\r\n\r\n\r\nGeneral Provisions\r\n\r\nTermination\r\nIn the event of termination, all licenses provided under this EULA shall immediately terminate, and you agree to discontinue accessing or attempting to access this Licensed product.\r\nAccordingly, this EULA may be:\r\nAutomatically terminated if the Licensee fails to comply with any of the terms and conditions under this EULA;\r\nTerminated by Noter; or\r\nTerminated by the Licensee.\r\nEither Noter or the Licensee may terminate this EULA immediately upon written notice to the other party, including but not limited to electronic mail.\r\nNon-Transferability\r\nThe Licensee has the option to permanently transfer all rights under this Agreement, provided the recipient agrees to the terms of this EULA. Accordingly, this EULA is not assignable or transferable by the Licensee without the prior written consent of Noter; and any attempt to do so shall be void.\r\n\r\nNotice\r\nAny notice, report, approval or consent required under this EULA shall be in writing and deemed to have been duly given if delivered by recorded delivery to the respective addresses of the parties.\r\n\r\nIntegration\r\nBoth parties hereby agree that this EULA is the entire and exclusive statement and legal acknowledgement of the mutual understanding of the parties and supersedes and cancels any previous written and oral agreement and/or communication relating to the subject matter of this EULA.\r\n\r\nSeverability\r\nNo delay or failure to exercise, on the part of either party, any privilege, power or rights under this EULA shall operate as a waiver of any of the terms and provisions of this EULA. Accordingly, no single or partial exercise of any right under this Agreement shall preclude further exercise of any other right under this EULA. Suppose any of the outlined provisions of this EULA is deemed to be unenforceable or invalid in whole or in part by a court of competent jurisdiction. In that case, such provision shall be limited to the minimum extent necessary for this EULA to remain in full force and effect and enforceable. The remaining provisions of this Agreement shall not be rendered unenforceable or invalid. They shall continue to be enforceable and valid in isolation of the unenforceable and invalid provisions of this EULA.\r\n\r\nWarranty and Disclaimer\r\nNoter, and author of this Software, expressly disclaim any warranty for the Noter. The Licensed Product and all applicable documentation is provided as-is, without warranty of any kind, whether express or implied, including, without limitation, the implied warranties of merchantability, fitness for a particular purpose, or non-infringement. Accordingly, the Licensee accepts any risk arising out of the use or performance of the Software.\r\n\r\nLimited Liability\r\nThe Licensee agrees that the Noter shall not be liable to Licensee, or any other related person or entity claiming any loss of profits, income, savings, or any other consequential, incidental, special, punitive, direct or indirect damage, whether arising in contract, tort, warranty, or otherwise. Even if Noter has been advised of the possibility of such damages. These limitations shall necessarily apply regardless of the primary purpose of any limited remedy. Under no circumstances shall Noter aggregate liability to the Licensee, or any other person or entity claiming through the Licensee, exceed the actual monetary amount paid by the Licensee to Noter for the Software.\r\n\r\nIndemnification\r\nYou hereby agree to indemnify and hold Noter harmless from and against all liabilities, damages, losses or expenses, including but not limited to reasonable attorney or other professional fees in any claim, demand, action or proceeding initiated by any third-party against Noter, arising from any of your acts, including without limitation, violating this EULA or any other agreement or any applicable law.\r\n\r\nEntire Agreement\r\nThis Agreement rightly constitutes the entire understanding between the Noter and the Licensee and all parties involved. It supersedes all prior agreements of the parties, whether written or oral, express or implied, statement, condition, or a representation or warranty.\r\n\r\nGoverning Law and Jurisdiction\r\nThis EULA shall be deemed to be construed under the jurisdiction of the courts located in New South Wales, without regard to conflicts of laws as regards the provisions thereof. Any legal action relating to this EULA shall be brought exclusively in the courts of New South Wales, and all parties consent to the jurisdiction thereof. Furthermore, the prevailing party in any action to enforce this EULA shall be entitled to recover costs and expenses including, without limitation, legal fees. Accordingly, this EULA is made within the exclusive jurisdiction of New South Wales, and its jurisdiction shall supersede any other jurisdiction of either party's election.\r\n\r\n";


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OtherInformationPage OtherInformationPage = new OtherInformationPage(userNameLoggedIn);
            this.Hide();
            OtherInformationPage.Show();
        }
    }
}

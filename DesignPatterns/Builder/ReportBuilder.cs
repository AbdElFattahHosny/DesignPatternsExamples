using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public abstract class ReportBuilder
    {
        //abstract methods
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();


        protected Report reportObject;
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            //return object of report
            return reportObject;
        }
    }
}

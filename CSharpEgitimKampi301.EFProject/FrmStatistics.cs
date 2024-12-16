using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db=new EgitimKampiEFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text=db.Location.Sum(x=>x.Capacity).ToString();
            lblGuideCount.Text=db.Guide.Count().ToString();
            lblAvgCapacity.Text= ((decimal)db.Location.Average(x=>x.Capacity)).ToString("F2");
            lblAvgLocationPrice.Text = ((decimal)db.Location.Average(x => x.Price)).ToString("F2");
            
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
           
            lblCappadociaLocationCapacity.Text=db.Location.Where(x=>x.City=="Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
           
            lblTurkiyeCapacityAvr.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();
            
            var romeguideId=db.Location.Where(x=>x.City=="Roma Turistik").Select(y=>y.LocationId).FirstOrDefault();
            lblRomeGuideName.Text=db.Guide.Where(x=>x.GuideId==romeguideId).Select(y=>y.GuideName+" "+y.GuideSurname).FirstOrDefault().ToString();
          
            var maxCapacity=db.Location.Max(x=>x.Capacity);
            lblMaxCapacity.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice=db.Location.Max(x=>x.Price);
            lblmaxPrice.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString() ;

            var guideIdByName=db.Guide.Where(x=>x.GuideName=="Ayşegül"&&x.GuideSurname=="Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByName).Count().ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

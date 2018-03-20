using EntertainmentNetwork.DAL.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models
{
    public class Show : BaseNotifyPropertyChanged, IShow
    {
        public Show() { }

        public Show(decimal shwId, string shwName, string shwDesc, string shwPerformer, byte[] shwIcon)
        {
            this.Id = shwId;
            this.ShwName = shwName;
            this.ShwDesc = shwDesc;
            this.ShwPerformer = shwPerformer;
            this.ShwIcon = shwIcon;
        }

        public bool IsNew
        {
            get
            {
                return this.Id == 0;
            }
        }

        public bool IsChanged { get; set; }

        public decimal Id
        {
            get { return this.showId; }
            set
            {
                this.SetPropertyValue(out this.showId, this.showId, value);
            }
        }

        public decimal ShwId
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }

        public string ShwName
        {
            get { return this.shwName; }
            set
            {
                this.SetPropertyValue(out this.shwName, this.shwName, value);
            }
        }

        public string ShwDesc
        {
            get { return this.shwDesc; }
            set
            {
                this.SetPropertyValue(out this.shwDesc, this.shwDesc, value);
            }
        }

        public string ShwPerformer
        {
            get { return this.shwPerformer; }
            set
            {
                this.SetPropertyValue(out this.shwPerformer, this.shwPerformer, value);
            }
        }

        public byte[] ShwIcon 
        {
            get { return this.shwIcon; }
            set
            {
                this.SetPropertyValue(out this.shwIcon, this.shwIcon, value);
            }
        }

        public void Update(IBaseModel model)
        {
            IShow show = (IShow)model;
            this.Id = show.Id;
            this.ShwName = show.ShwName;
            this.ShwDesc = show.ShwDesc;
            this.ShwPerformer = show.ShwPerformer;
            this.ShwIcon = show.ShwIcon;
        }

        public override bool Equals(object show)
        {
            IShow showToCompare = show as IShow;
            return showToCompare != null && this.Id.Equals(showToCompare.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        private decimal showId;
        private string shwDesc;
        private string shwName;
        private string shwPerformer;
        private byte[] shwIcon;
    }
}

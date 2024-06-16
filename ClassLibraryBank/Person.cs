using System.ComponentModel.DataAnnotations;

namespace ClassLibraryBank
{
    public interface IPerson
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public int mobileNo { get; set; }
        public string email { get; set; }

       
     
    }

    
}

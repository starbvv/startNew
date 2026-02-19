using System.ComponentModel;
namespace start.Models
{
    public class Coaches
    {
        //=======================================================//
        [Browsable(false)]
        public int Id { get; set; }
        //=======================================================//

        //=======================================================//
        [DisplayName("ФИО")]
        public string FullName { get; set; } = null!;
        //=======================================================//

        //=======================================================//
        [DisplayName("Тип спорта")]
        public string SportType { get; set; } = null!;
        //=======================================================//

        public override string ToString() => $"{FullName}";
    }
}

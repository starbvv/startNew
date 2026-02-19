using System.ComponentModel;
namespace start.Models
{
    public class Sportsmen
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
        [DisplayName("Дата рождения")]
        public DateTime Bday { get; set; }
        //=======================================================//

        //=======================================================//
        [DisplayName("Номер родителя")]
        public string ParentPhone { get; set; } = null!;
        //=======================================================//

        public override string ToString() => $"{FullName}";
    }
}

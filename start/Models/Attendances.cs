using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace start.Models
{
    public class Attendances
    {
        //=======================================================//
        [Browsable(false)]
        public int Id { get; set; }
        //=======================================================//

        //=======================================================//
        [DisplayName("Спортсмен")]
        public Sportsmen Sportsmen { get; set; } = new();
        //=======================================================//

        //=======================================================//
        [DisplayName("Тренер")]
        public Coaches Coaches { get; set; } = new();
        //=======================================================//

        //=======================================================//
        [DisplayName ("Дата тренировке")]
        public DateTime TrainingDate { get; set; }
        //=======================================================//

        //=======================================================//
        [DisplayName("Был на тренировке")]
        public bool Attended { get; set; } = false;
        //=======================================================//
    }
}

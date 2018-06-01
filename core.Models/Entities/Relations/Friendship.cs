using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Entities.Relations
{
    public class Friendship
    {
        private int _id;
        private string _idRequesting;
        private string _idReceiving;
        private DateTime _date;
        private bool _active;
        private ApplicationUser requesting;
        private ApplicationUser receiving;



        public int Id { get => _id; set => _id = value; }
        public string IdRequesting { get => _idRequesting; set => _idRequesting = value; }
        public string IdReceiving { get => _idReceiving; set => _idReceiving = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public bool Active { get => _active; set => _active = value; }




        public ApplicationUser Requesting { get => requesting; set => requesting = value; }
        public ApplicationUser Receiving { get => receiving; set => receiving = value; }    
    }
}

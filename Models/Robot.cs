using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Models
{
    public class Robot
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }
        public Torso Torso { get; set; }
        public Head Head { get; set; }

        public Robot ( string name, List<Arm> arms, List<Leg> legs, Torso torso, Head head)
        {
            
            Name = name;
            Arms = arms;
            Legs = legs;
            Torso = torso;
            Head = head;
        }

        public override string ToString()
        {
            return $"ID: { Id }, Name: {Name}, Arms: {Arms[1]}, Legs: {Legs[1]}";
                     
                   
        }

    }
}

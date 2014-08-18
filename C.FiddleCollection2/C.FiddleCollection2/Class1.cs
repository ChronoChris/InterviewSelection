using C.FiddleCollection2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.FiddleCollection2
{
    public class Animal 
    {
        public string Name;
        public int Popularity;
        public Zoo zoo { get; internal set; }
    public Animal (string name, int popularity)
    {
        name = Name; popularity = Popularity;
    }
    }

public class AnimalCollection : Collection<Animal>
{
    Zoo zoo;
    public AnimalCollection (Zoo zoo) { this.zoo = zoo; }
    protected override void InsertItem(int index, Animal item)
    {
        base.InsertItem(index, item);
        item.zoo = zoo;
    }
    protected override void SetItem(int index, Animal item)
    {
        base.SetItem(index, item);
    }
    protected override void RemoveItem(int index)
    {
        this[index].zoo = null;
        base.RemoveItem(index);
    }

}
public class Zoo
{
    public readonly AnimalCollection AnimalatZoo;
    public Zoo() { AnimalatZoo = new AnimalCollection(this); }
}

}

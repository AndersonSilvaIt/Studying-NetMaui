namespace JogosInfantis.Models
{
    public class JogoData
    {
        public List<JogoItem> Animals { get; set; }
        public List<JogoItem> Letters { get; set; }
        public List<JogoItem> Numbers { get; set; }
        public List<JogoItem> Colors { get; set; }
        public List<JogoItem> Fruits { get; set; }
        public List<JogoItem> Shapes { get; set; }

        public JogoData()
        {
            Animals = new List<JogoItem>()
        {
            new JogoItem() { Name = "Lion", ImageUrl = "lion.png" },
            new JogoItem() { Name = "Fox", ImageUrl = "fox.png" },
            new JogoItem() { Name = "Tiger", ImageUrl = "tiger.png" },
            new JogoItem() { Name = "Elephant", ImageUrl = "Elephant.png" },
            new JogoItem() { Name = "Zebra", ImageUrl = "zebra.png" },
            new JogoItem() { Name = "Monkey", ImageUrl = "monkey.png" },
            new JogoItem() { Name = "Giraffe", ImageUrl = "giraffe.png" },
            new JogoItem() { Name = "Dog", ImageUrl = "Dog.png" },
            new JogoItem() { Name = "Cat", ImageUrl = "cat.png" },
            new JogoItem() { Name = "Rabbit", ImageUrl = "rabbit.png" },
            new JogoItem() { Name = "Horse", ImageUrl = "horse.png" },
            new JogoItem() { Name = "Rooster", ImageUrl = "rooster.png" },
        };

            Letters = new List<JogoItem>()
        {
           new JogoItem(){Name="a", ImageUrl="alphabet_a.png"},
           new JogoItem(){Name="b", ImageUrl="alphabet_b.png"},
           new JogoItem(){Name="c", ImageUrl="alphabet_c.png"},
           new JogoItem(){Name="d", ImageUrl="alphabet_d.png"},
           new JogoItem(){Name="e", ImageUrl="alphabet_e.png"},
           new JogoItem(){Name="f", ImageUrl="alphabet_f.png"},
           new JogoItem(){Name="g", ImageUrl="alphabet_g.png"},
           new JogoItem(){Name="h", ImageUrl="alphabet_h.png"},
           new JogoItem(){Name="i", ImageUrl="alphabet_i.png"},
           new JogoItem(){Name="j", ImageUrl="alphabet_j.png"},
           new JogoItem(){Name="k", ImageUrl="alphabet_k.png"},
           new JogoItem(){Name="l", ImageUrl="alphabet_l.png"},
           new JogoItem(){Name="m", ImageUrl="alphabet_m.png"},
           new JogoItem(){Name="n", ImageUrl="alphabet_n.png"},
           new JogoItem(){Name="o", ImageUrl="alphabet_o.png"},
           new JogoItem(){Name="p", ImageUrl="alphabet_p.png"},
           new JogoItem(){Name="q", ImageUrl="alphabet_q.png"},
           new JogoItem(){Name="r", ImageUrl="alphabet_r.png"},
           new JogoItem(){Name="s", ImageUrl="alphabet_s.png"},
           new JogoItem(){Name="t", ImageUrl="alphabet_t.png"},
           new JogoItem(){Name="u", ImageUrl="alphabet_u.png"},
           new JogoItem(){Name="v", ImageUrl="alphabet_v.png"},
           new JogoItem(){Name="w", ImageUrl="alphabet_w.png"},
           new JogoItem(){Name="x", ImageUrl="alphabet_x.png"},
           new JogoItem(){Name="y", ImageUrl="alphabet_y.png"},
           new JogoItem(){Name="z", ImageUrl="alphabet_z.png"},
        };

            Numbers = new List<JogoItem>()
        {
          new JogoItem() { Name = "One", ImageUrl = "one.png" },
          new JogoItem() { Name = "Two", ImageUrl = "two.png" },
          new JogoItem() { Name = "Three", ImageUrl = "three.png" },
          new JogoItem() { Name = "Four", ImageUrl = "four.png" },
          new JogoItem() { Name = "Five", ImageUrl = "five.png" },
          new JogoItem() { Name = "Six", ImageUrl = "six.png" },
          new JogoItem() { Name = "Seven", ImageUrl = "seven.png" },
          new JogoItem() { Name = "Eight", ImageUrl = "eight.png" },
          new JogoItem() { Name = "Nine", ImageUrl = "nine.png" },
          new JogoItem() { Name = "Ten", ImageUrl = "ten.png" },

        };
            Colors = new List<JogoItem>()
        {
           new JogoItem() { Name = "Black", ImageUrl = "color_black.png" },
           new JogoItem() { Name = "Blue", ImageUrl = "color_blue.png" },
           new JogoItem() { Name = "Gray", ImageUrl = "color_gray.png" },
           new JogoItem() { Name = "Green", ImageUrl = "color_green.png" },
           new JogoItem() { Name = "Orange", ImageUrl = "color_orange.png" },
           new JogoItem() { Name = "Purple", ImageUrl = "color_purple.png" },
           new JogoItem() { Name = "Red", ImageUrl = "color_red.png" },
           new JogoItem() { Name = "Yellow", ImageUrl = "color_yellow.png" },

        };

            Fruits = new List<JogoItem>()
       {
           new JogoItem { Name = "Apple", ImageUrl = "apple.png" },
           new JogoItem { Name = "Banana", ImageUrl = "banana.png" },
           new JogoItem { Name = "Orange", ImageUrl = "orange.png" },
           new JogoItem { Name = "Strawberry", ImageUrl = "strawberry.png" },
           new JogoItem { Name = "Mango", ImageUrl = "mango.png" },
           new JogoItem { Name = "Kiwi", ImageUrl = "kiwi.png" },
           new JogoItem { Name = "Watermelon", ImageUrl = "watermelon.png" },
           new JogoItem { Name = "Grapes", ImageUrl = "grapes.png" },
           new JogoItem { Name = "Pineapple", ImageUrl = "pineapple.png" },
           new JogoItem { Name = "Coconut", ImageUrl = "coconut.png" },
           new JogoItem { Name = "Peach", ImageUrl = "peach.png" },
           new JogoItem { Name = "Apricot", ImageUrl = "apricot.png" },
           new JogoItem { Name = "Guava", ImageUrl = "guava.png" },
           new JogoItem { Name = "Avocado", ImageUrl = "avocado.png" },
       };

            Shapes = new List<JogoItem>()
        {
           new JogoItem() { Name = "Triangle", ImageUrl = "triangle.png" },
           new JogoItem() { Name = "Circle", ImageUrl = "circle.png" },
           new JogoItem() { Name = "Square", ImageUrl = "square.png" },
           new JogoItem() { Name = "Rectangle", ImageUrl = "rectangle.png" },
           new JogoItem() { Name = "Oval", ImageUrl = "oval.png" },
           new JogoItem() { Name = "Star", ImageUrl = "star.png" },
           new JogoItem() { Name = "Heart", ImageUrl = "heart.png" },
           new JogoItem() { Name = "Arrow", ImageUrl = "arrow.png" },
           new JogoItem() { Name = "Pyramid", ImageUrl = "pyramid.png" },
           new JogoItem() { Name = "Cube", ImageUrl = "cube.png" },
        };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary.Repository
{
    public class ListBoxRepository : IRepositoryBase<Box>
    {
        private List<Box> _boxes;


        public ListBoxRepository(List<Box> boxes)
        {
            Boxes = boxes;
        }

        public List<Box> Boxes
        {
            get => _boxes;
            set => _boxes = value;
        }

        public Box Get(string id)
        {
            return _boxes
                .AsParallel()
                .FirstOrDefault(el => el.Id == id);
        }

        public Box Add(Box item)
        {
            Boxes.Add(item);
            return item;
        }

        public void Update(Box item)
        {
            var box = Get(item.Id);
            if (box != null)
            {
                box.ExpirationDate = item.ExpirationDate;
                box.ProductionDate = item.ProductionDate;
            }
        }

        public void Delete(string id)
        {
            var box = Get(id);
            if (box != null)
            {
                Boxes.Remove(box);
            }
        }

        public IEnumerable<Box> GetAll()
        {
            return Boxes;
        }

        public IEnumerable<Box> Find(Func<Box, bool> predicate)
        {
           return Boxes
               .AsParallel()
               .Where(predicate)
               .AsEnumerable();
        }

        public bool Any(Func<Box, bool> predicate)
        {
            return Boxes
                .AsParallel()
                .Any(predicate);
        }
    }
}

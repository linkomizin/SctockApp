using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary.Repository
{
    public class LIstPalletRepository : IRepositoryBase<Pallet>
    {
        private List<Pallet> _pallets;


        public LIstPalletRepository(List<Pallet> pallets)
        {
            Pallets = pallets;
        }

        public List<Pallet> Pallets
        {
            get => _pallets;
            set => _pallets = value;
        }

        public Pallet Get(string id)
        {
            return _pallets
                .AsParallel()
                .FirstOrDefault(el => el.Id == id);
        }

        public Pallet Add(Pallet item)
        {
            Pallets.Add(item);
            return item;
        }

        public void Update(Pallet item)
        {
            var element = Get(item.Id);
            if (element != null)
            {
                element.Boxes = item.Boxes;
            }
        }

        public void Delete(string id)
        {
            var element = Get(id);
            if (element != null)
            {
                Pallets.Remove(element);
            }
        }

        public IEnumerable<Pallet> GetAll()
        {
            return Pallets;
        }

        public IEnumerable<Pallet> Find(Func<Pallet, bool> predicate)
        {
            return Pallets
                .AsParallel()
                .Where(predicate)
                .AsEnumerable();
        }

        public bool Any(Func<Pallet, bool> predicate)
        {
            return Pallets
                .AsParallel()
                .Any(predicate);
        }
    }
}

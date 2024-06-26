﻿using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class AdressManager : IAdressService
    {
        private readonly IAdressDal _adressDal;

        public AdressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public void Delete(Adress t)
        {
            throw new NotImplementedException();
        }

        public Adress GetById(int id)
        {
            return _adressDal.GetById(id);
        }

        public List<Adress> GetListAll()
        {
            return _adressDal.GetListAll();
        }

        public void Insert(Adress t)
        {
            throw new NotImplementedException();
        }

        public void Update(Adress t)
        {
            _adressDal.Update(t);
        }
    }
}

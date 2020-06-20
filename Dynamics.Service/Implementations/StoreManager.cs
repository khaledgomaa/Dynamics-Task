﻿using Dynamics.Domain;
using Dynamics.Repository;
using Dynamics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamics.Service.Implementations
{
    public class StoreManager : IStoreManager
    {
        private IUnitOfWork unitOfWork;

        public StoreManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add(Store entity)
        {
            unitOfWork.StoresRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Store> entity)
        {
            throw new NotImplementedException();
        }

        public void Complete()
        {
            unitOfWork.Complete();
        }

        public IEnumerable<Store> GetAll()
        {
            return unitOfWork.StoresRepository.GetAll().ToList();
        }

        public IEnumerable<Store> GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(Store entity)
        {
            throw new NotImplementedException();
        }
    }
}

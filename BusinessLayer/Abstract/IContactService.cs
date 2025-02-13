﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> List();
        void ContactAdd(Contact contact);
        Contact GetByID(int id);
        void DeleteContact(Contact contact);
        void ContactUpdate(Contact contact);
    }
}

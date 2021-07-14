﻿using Books.Business.DataTransferObjects;
using Books.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Business
{
    public interface IPublisherService
    {
        IList<PublisherListResponse> GetAllPublisher();

        //returns Last Added Value's Id
        int AddPublisher(AddNewPublisherRequest request);
        PublisherListResponse GetPublisherById(int id);
        int UpdatePublisher(EditPublisherRequest request);
        void DeletePublisher(int id);
    }
}

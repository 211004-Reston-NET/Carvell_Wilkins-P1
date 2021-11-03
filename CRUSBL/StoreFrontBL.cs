using System;
using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;



namespace CRUSBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class StoreFrontBL : IStoreFrontBL
    {
        private IRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }



        public List<StoreFront> GetAllStoreFront()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<StoreFront> listOfStoreFront = _repo.GetAllStoreFront();
            for (int i = 0; i < listOfStoreFront.Count; i++)
            {
                listOfStoreFront[i].Name = listOfStoreFront[i].Name.ToLower();
            }

            return listOfStoreFront;
        }



    }
}

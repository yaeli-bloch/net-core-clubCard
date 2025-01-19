//using Microsoft.AspNetCore.Mvc;
//using Club;
//using Club.ApiNew.Controllers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnitTest
//{
//    public class EventControllerTest
//    {
//        private ClubCardController _cardController;
//        public EventControllerTest()
//        {
//            FakeContext context = new FakeContext();
//            _cardController= new ClubCardController(context);
//        }
//        [Fact]
//      public void GetAll_ReturnsListOfClubCard()
//      {
//            var controller = _cardController;
//            var result = controller.Get();
//            Assert.IsType<List<Clubcard>>(result);
//      }
//        [Fact]
//        public void GetById_ReturnsOk()
//        {
//            string id = "1";
//            var controller = _cardController;
//            var result=controller.Get(id);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void GetById_ReturnsNoFound()
//        {
//            string id = "2";
//            var controller = _cardController;
//            var result = controller.Get(id);
//            Assert.IsType<NotFoundResult>(result);
//        }
//    }
//}

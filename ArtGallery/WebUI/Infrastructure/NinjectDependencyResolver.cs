using Domain.Abstract;
using Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            Mock<IArtRepository> mock = new Mock<IArtRepository>();
            mock.Setup(m => m.Arts).Returns(new List<Art>
            {
                new Art
                {
                    ArtName = "Девушка с жемчужной серёжкой",
                    ArtOriginName ="Het meisje met de parel",
                    CreationDate = "1665 год",
                    Description ="Одна из наиболее известных картин нидерландского художника Яна Вермеера. Её часто называют северной или голландской Моной Лизой.",
                    Size ="45 х 39",
                    Price = 85000
                },
                new Art
                {
                    ArtName = "Звёздная ночь",
                    ArtOriginName ="De sterrennacht",
                    CreationDate = "1889 год",
                    Description =" Одна из наиболее известных картин нидерландского художника-постимпрессиониста Винсента Ван Гога. Представляет вид из восточного окна спальни Ван Гога в Сен-Реми-де-Прованс на предрассветное небо и вымышленную деревню. ",
                    Size ="74 х 92",
                    Price = 70000
                },
                new Art
                {
                    ArtName = "Мо́на Ли́за",
                    ArtOriginName ="Ritratto di Monna Lisa del Giocondo",
                    CreationDate = "1503- 1505 год",
                    Description ="Картина Леонардо да Винчи, находящаяся в Лувре (Париж, Франция), одно из самых известных произведений живописи в мире[1][2], которое, как считается, является портретом Лизы Герардини, супруги торговца шёлком из Флоренции Франческо дель Джокондо, написанным около 1503—1505 года.",
                    Size ="77 х 53",
                    Price = 15000
                }
            });
            kernel.Bind<IArtRepository>().ToConstant(mock.Object);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
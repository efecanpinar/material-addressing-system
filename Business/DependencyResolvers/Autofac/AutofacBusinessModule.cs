using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HallManager>().As<IHallService>();
            builder.RegisterType<EfHallDal>().As<IHallDal>();

            builder.RegisterType<CabinetManager>().As<ICabinetService>();
            builder.RegisterType<EfCabinetDal>().As<ICabinetDal>();

            builder.RegisterType<CellManager>().As<ICellService>();
            builder.RegisterType<EfCellDal>().As<ICellDal>();

            builder.RegisterType<ShelfManager>().As<IShelfService>();
            builder.RegisterType<EfShelfDal>().As<IShelfDal>();

            builder.RegisterType<PartManager>().As<IPartService>();
            builder.RegisterType<EfPartDal>().As<IPartDal>();
        }
    }
}

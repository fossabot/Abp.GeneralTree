﻿using System.Reflection;
using Abp.Dependency;
using Abp.Modules;

namespace Abp.GeneralTree
{
    [DependsOn(typeof(AbpKernelModule))]
    public class GeneralTreeModule : AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.Register(typeof(IGeneralTreeManager<,>), typeof(GeneralTreeManager<,>),
                DependencyLifeStyle.Transient);

            IocManager.Register(typeof(IGeneralTreeManagerWithReferenceType<,>),
                typeof(GeneralTreeManagerWithReferenceType<,>),
                DependencyLifeStyle.Transient);

            IocManager.Register(typeof(IGeneralTreeConfiguration<,>), typeof(GeneralTreeConfiguration<,>));

            IocManager.Register(typeof(IGeneralTreeConfigurationWithReferenceType<,>),
                typeof(GeneralTreeConfigurationWithReferenceType<,>));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
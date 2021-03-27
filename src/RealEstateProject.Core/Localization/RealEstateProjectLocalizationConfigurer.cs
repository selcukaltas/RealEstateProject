using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RealEstateProject.Localization
{
    public static class RealEstateProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RealEstateProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RealEstateProjectLocalizationConfigurer).GetAssembly(),
                        "RealEstateProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

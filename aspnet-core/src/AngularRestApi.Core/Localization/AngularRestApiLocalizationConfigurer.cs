using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AngularRestApi.Localization
{
    public static class AngularRestApiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AngularRestApiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AngularRestApiLocalizationConfigurer).GetAssembly(),
                        "AngularRestApi.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

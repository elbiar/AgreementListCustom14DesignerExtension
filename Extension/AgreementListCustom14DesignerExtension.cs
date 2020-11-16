using System;
using System.Collections.Generic;
using System.Resources;
using DocsVision.Platform.Tools.LayoutEditor.Extensibility;
using DocsVision.Platform.Tools.LayoutEditor.ObjectModel.Descriptions;

namespace AgreementListCustom14DesignerExtension.Extension
{
    /// <summary>
    /// Представляет собой пример расширения для редактора разметок
    /// </summary>
    class AgreementListCustom14DesignerExtension : WebLayoutsDesignerExtension
    {
        /// <summary>
        /// Создаёт новый экземпляр <see cref="AgreementListCustom14DesignerExtension"/>
        /// </summary>
        /// <param name="provider">Сервис-провайдер</param>
        public AgreementListCustom14DesignerExtension(IServiceProvider provider)
            : base(provider)
        {
        }

        /// <summary>
        /// Возвращает словарь ключ/описание свойства, которые будут использоваться в пользовательских контролах
        /// </summary>
        protected override Dictionary<string, PropertyDescription> GetPropertyDescriptions()
        {
            return new Dictionary<string, PropertyDescription>
            {

            };
        }

        /// <summary>
        /// Возвращает описание пользовательских контролов
        /// описание контрола PartnerLink выполнено альтернативным способом и содержится в каталоге xml
        /// </summary>
        protected override List<ControlTypeDescription> GetControlTypeDescriptions()
        {
            return new List<ControlTypeDescription>
            {
            };
        }

        /// <summary>
        /// Возвращает ResourceManager этого расширения (расширяет словарь локализации конструктора разметок, не путать с окном Localization конструктора разметок)
        /// </summary>
        protected override List<ResourceManager> GetResourceManagers()
        {
            return new List<ResourceManager>
            {
                Resources.ResourceManager
            };
        }
    }
}

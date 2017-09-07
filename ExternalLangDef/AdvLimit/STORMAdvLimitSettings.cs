﻿namespace ICSSoft.STORMNET.Windows.Forms
{
#if DNX4
    using ICSSoft.Services;
#endif

    /// <summary>
    /// Объектное представление сохраняемого в базе ограничения.
    /// Не содержит логики по десериализации.
    /// Сам класс знает только сериализованное Value.
    /// Десериализуется в своё нехранимое свойство AdvLimit при помощи AdvLimitComponent.
    /// </summary>
    public partial class STORMAdvLimit
    {
        private bool fPublished;

        /// <summary>
        /// Опубликовано ли
        /// </summary>
        public virtual bool Published
        {
            get
            {
                bool result = this.fPublished;
                return result;
            }
            set
            {
                fPublished = value;
                User = System.Environment.UserName;
#if DNX4
                User = value ? null : CurrentUserService.CurrentUser.FriendlyName;
#endif
            }
        }
    }
}
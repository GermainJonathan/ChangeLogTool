using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    /**
     * Model de donnée des permissions
     */
    class Permission
    {
        /**
         * Identifiant de la permission
         */
        private string id { get; }

        /**
         * Clé de la permission
         */
        private string key { get; }

        /**
         * Nom de la permission
         */
        private string name { get; }

        /**
         * Type de permission
         */
        private string type { get; }

        /**
         * Explication de la premission
         */
        private string description { get; }

        /**
         * Etat de la permission - Indique si elle est active
         */
        private bool havePermission { get; }

        /**
         * Propriété optionnel - Indique si la permission est obsolète
         */
        private bool deprecatedKey { get; }
    }
}

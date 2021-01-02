﻿using System.Linq;

namespace Diverse
{
    /// <summary>
    /// Information related to female persons.
    /// </summary>
    public static class Female
    {
        /// <summary>
        /// Gets all the <see cref="ContextualizedFirstName"/> instances possibly used by the lib.
        /// </summary>
        public static ContextualizedFirstName[] ContextualizedFirstNames => _contextualizedFirstNames;

        private static string[] _firstNames = null;

        /// <summary>
        /// Gets all the female first names possibly used by the lib.
        /// </summary>
        public static string[] FirstNames
        {
            get
            {
                if (_firstNames == null)
                {
                    _firstNames = Female.ContextualizedFirstNames
                        .Where(x => !string.IsNullOrWhiteSpace(x.FirstName))
                        .Select(m => m.FirstName)
                        .Distinct()
                        .ToArray();
                }

                return _firstNames;
            }
        }

        private static readonly ContextualizedFirstName[] _contextualizedFirstNames = new ContextualizedFirstName[]
        {
            new ContextualizedFirstName("Aaliyah", Continent.Africa),
            new ContextualizedFirstName("Alyssa", Continent.Africa),
            new ContextualizedFirstName("Bintu", Continent.Africa),
            new ContextualizedFirstName("Jemila", Continent.Africa),
            new ContextualizedFirstName("Jendayi", Continent.Africa),
            new ContextualizedFirstName("Keisha", Continent.Africa),
            new ContextualizedFirstName("Laila", Continent.Africa),
            new ContextualizedFirstName("Abeba", Continent.Africa),
            new ContextualizedFirstName("Aminata", Continent.Africa),
            new ContextualizedFirstName("Isis", Continent.Africa),
            new ContextualizedFirstName("Makeba", Continent.Africa),
            new ContextualizedFirstName("Malika", Continent.Africa),
            new ContextualizedFirstName("Rokhaya", Continent.Africa),
            new ContextualizedFirstName("Fatoumata", Continent.Africa),
            new ContextualizedFirstName("Awa", Continent.Africa),
            new ContextualizedFirstName("Aissatou", Continent.Africa),
            new ContextualizedFirstName("Mariama", Continent.Africa),
            new ContextualizedFirstName("Khadidiatou", Continent.Africa),
            new ContextualizedFirstName("Aida", Continent.Africa),
            new ContextualizedFirstName("Ramatoulaye", Continent.Africa),
            new ContextualizedFirstName("Rama", Continent.Africa),
            new ContextualizedFirstName("Nzinga", Continent.Africa),
            new ContextualizedFirstName("Nakeisha", Continent.Africa),
            new ContextualizedFirstName("Zahara", Continent.Africa),
            new ContextualizedFirstName("Zuri", Continent.Africa),
            new ContextualizedFirstName("Kwame", Continent.Africa),
            new ContextualizedFirstName("Amber", Continent.Africa),
            new ContextualizedFirstName("Qwara", Continent.Africa),
            new ContextualizedFirstName("Nyofu", Continent.Africa),
            new ContextualizedFirstName("Ekundayo", Continent.Africa),
            new ContextualizedFirstName("Kione", Continent.Africa),
            new ContextualizedFirstName("Thenjiwe", Continent.Africa),
            new ContextualizedFirstName("Johari", Continent.Africa),
            new ContextualizedFirstName("Tene", Continent.Africa),
            new ContextualizedFirstName("Nimeesha", Continent.Africa),
            new ContextualizedFirstName("Nkechi", Continent.Africa),

            new ContextualizedFirstName("Rim", Continent.Africa),
            new ContextualizedFirstName("Nora", Continent.Africa),
            new ContextualizedFirstName("Sarah", Continent.Africa),
            new ContextualizedFirstName("Fatima", Continent.Africa),
            new ContextualizedFirstName("Noûr", Continent.Africa),
            new ContextualizedFirstName("Louna", Continent.Africa),
            new ContextualizedFirstName("Maïssa", Continent.Africa),
            new ContextualizedFirstName("Kenza", Continent.Africa),
            new ContextualizedFirstName("Selma", Continent.Africa),
            new ContextualizedFirstName("Jasmine", Continent.Africa),
            new ContextualizedFirstName("Janna", Continent.Africa),
            new ContextualizedFirstName("Mériem", Continent.Africa),
            new ContextualizedFirstName("Zayneb", Continent.Africa),
            new ContextualizedFirstName("Khadija", Continent.Africa),
            new ContextualizedFirstName("Iman", Continent.Africa),
            new ContextualizedFirstName("Mouna", Continent.Africa),
            new ContextualizedFirstName("Ayisha", Continent.Africa),
            new ContextualizedFirstName("Aicha", Continent.Africa),
            new ContextualizedFirstName("Jamila", Continent.Africa),
            new ContextualizedFirstName("Farida", Continent.Africa),
            new ContextualizedFirstName("Kelthouma", Continent.Africa),
            new ContextualizedFirstName("Samia", Continent.Africa),
            new ContextualizedFirstName("Asma", Continent.Africa),
            new ContextualizedFirstName("Leila", Continent.Africa),

            new ContextualizedFirstName("Solveig", Continent.Antarctica),
            new ContextualizedFirstName("Freja", Continent.Antarctica),
            new ContextualizedFirstName("Kirsten", Continent.Antarctica),
            new ContextualizedFirstName("Mette", Continent.Antarctica),
            new ContextualizedFirstName("Liv", Continent.Antarctica),
            new ContextualizedFirstName("Erika", Continent.Antarctica),
            new ContextualizedFirstName("Maja", Continent.Antarctica),
            new ContextualizedFirstName("Ida", Continent.Antarctica),
            new ContextualizedFirstName("Anouk", Continent.Antarctica),
            new ContextualizedFirstName("Johanna", Continent.Antarctica),
            new ContextualizedFirstName("Mathilda", Continent.Antarctica),
            new ContextualizedFirstName("Sigrid", Continent.Antarctica),
            new ContextualizedFirstName("Anya", Continent.Antarctica),
            new ContextualizedFirstName("Kristina", Continent.Antarctica),
            new ContextualizedFirstName("Gefjun", Continent.Antarctica),
            new ContextualizedFirstName("Edda", Continent.Antarctica),
            new ContextualizedFirstName("Byrget", Continent.Antarctica),
            new ContextualizedFirstName("Frigga", Continent.Antarctica),
            new ContextualizedFirstName("Norne", Continent.Antarctica),
            new ContextualizedFirstName("Lidweina", Continent.Antarctica),
            new ContextualizedFirstName("Signilde", Continent.Antarctica),
            new ContextualizedFirstName("Brendette", Continent.Antarctica),
            new ContextualizedFirstName("Trini", Continent.Antarctica),
            new ContextualizedFirstName("Asti", Continent.Antarctica),
            new ContextualizedFirstName("Astryr", Continent.Antarctica),
            new ContextualizedFirstName("Gefjun", Continent.Antarctica),
            new ContextualizedFirstName("Erna", Continent.Antarctica),
            new ContextualizedFirstName("Ursule", Continent.Antarctica),
            new ContextualizedFirstName("Solveig", Continent.Antarctica),
            new ContextualizedFirstName("Erike", Continent.Antarctica),

            new ContextualizedFirstName("Ahnjong", Continent.Asia),
            new ContextualizedFirstName("Kyeol", Continent.Asia),
            new ContextualizedFirstName("Ja-kyung", Continent.Asia),
            new ContextualizedFirstName("Jeong-ja", Continent.Asia),
            new ContextualizedFirstName("Ji-yeon", Continent.Asia),
            new ContextualizedFirstName("Jung-sook", Continent.Asia),
            new ContextualizedFirstName("Bae", Continent.Asia),
            new ContextualizedFirstName("Bitna", Continent.Asia),
            new ContextualizedFirstName("Bong-Cha", Continent.Asia),
            new ContextualizedFirstName("Byeol", Continent.Asia),
            new ContextualizedFirstName("Choon-He", Continent.Asia),
            new ContextualizedFirstName("Chul", Continent.Asia),
            new ContextualizedFirstName("Dae", Continent.Asia),
            new ContextualizedFirstName("Eun-Kyung", Continent.Asia),
            new ContextualizedFirstName("Goo", Continent.Asia),
            new ContextualizedFirstName("Hei-Ran", Continent.Asia),
            new ContextualizedFirstName("Hyo", Continent.Asia),

            new ContextualizedFirstName("Diễm Hạnh", Continent.Asia),
            new ContextualizedFirstName("Duong Liễu", Continent.Asia),
            new ContextualizedFirstName("Mai Lan", Continent.Asia),
            new ContextualizedFirstName("Mây", Continent.Asia),
            new ContextualizedFirstName("My Lê", Continent.Asia),
            new ContextualizedFirstName("Tuong Vi", Continent.Asia),
            new ContextualizedFirstName("Vân", Continent.Asia),
            new ContextualizedFirstName("Xuân", Continent.Asia),
            new ContextualizedFirstName("Khuong", Continent.Asia),
            new ContextualizedFirstName("Nhu", Continent.Asia),
            new ContextualizedFirstName("Cai", Continent.Asia),
            new ContextualizedFirstName("Nhung", Continent.Asia),
            new ContextualizedFirstName("Thuong", Continent.Asia),

            new ContextualizedFirstName("Zhang", Continent.Asia),
            new ContextualizedFirstName("Mei", Continent.Asia),
            new ContextualizedFirstName("Lin", Continent.Asia),
            new ContextualizedFirstName("Wen", Continent.Asia),
            new ContextualizedFirstName("Xian", Continent.Asia),
            new ContextualizedFirstName("Jiao", Continent.Asia),
            new ContextualizedFirstName("Lan", Continent.Asia),
            new ContextualizedFirstName("Chan", Continent.Asia),
            new ContextualizedFirstName("Li", Continent.Asia),
            new ContextualizedFirstName("Xiu", Continent.Asia),
            new ContextualizedFirstName("Li Mei", Continent.Asia),
            new ContextualizedFirstName("Zhi", Continent.Asia),
            new ContextualizedFirstName("Meiling", Continent.Asia),
            new ContextualizedFirstName("Qi", Continent.Asia),
            new ContextualizedFirstName("Bao", Continent.Asia),
            new ContextualizedFirstName("Chen", Continent.Asia),
            new ContextualizedFirstName("Shu Fang", Continent.Asia),
            new ContextualizedFirstName("Li Ming", Continent.Asia),
            new ContextualizedFirstName("Xing Xing", Continent.Asia),
            new ContextualizedFirstName("Yue", Continent.Asia),
            new ContextualizedFirstName("Qiao", Continent.Asia),

            new ContextualizedFirstName("Avigail", Continent.Asia),
            new ContextualizedFirstName("Bayla", Continent.Asia),
            new ContextualizedFirstName("Esther", Continent.Asia),
            new ContextualizedFirstName("Ednah", Continent.Asia),
            new ContextualizedFirstName("Ashra", Continent.Asia),
            new ContextualizedFirstName("Zakyla", Continent.Asia),
            new ContextualizedFirstName("Shalvah", Continent.Asia),
            new ContextualizedFirstName("Misha", Continent.Asia),
            new ContextualizedFirstName("Malka", Continent.Asia),
            new ContextualizedFirstName("Meirav", Continent.Asia),
            new ContextualizedFirstName("Yael", Continent.Asia),
            new ContextualizedFirstName("Eliszabeth", Continent.Asia),
            new ContextualizedFirstName("Doveva", Continent.Asia),
            new ContextualizedFirstName("Nataniya", Continent.Asia),
            new ContextualizedFirstName("Samarah", Continent.Asia),
            new ContextualizedFirstName("Dinah", Continent.Asia),

            new ContextualizedFirstName("Kamini", Continent.Asia),
            new ContextualizedFirstName("Akshara", Continent.Asia),
            new ContextualizedFirstName("Amruta", Continent.Asia),
            new ContextualizedFirstName("Deepa", Continent.Asia),
            new ContextualizedFirstName("Ishani", Continent.Asia),
            new ContextualizedFirstName("Lajita", Continent.Asia),
            new ContextualizedFirstName("Rajeshri", Continent.Asia),
            new ContextualizedFirstName("Suhani", Continent.Asia),
            new ContextualizedFirstName("Indu", Continent.Asia),
            new ContextualizedFirstName("Vasatika", Continent.Asia),
            new ContextualizedFirstName("Trisha", Continent.Asia),
            new ContextualizedFirstName("Devi", Continent.Asia),
            new ContextualizedFirstName("Usha", Continent.Asia),
            new ContextualizedFirstName("Shanti", Continent.Asia),
            new ContextualizedFirstName("Ameeta", Continent.Asia),
            new ContextualizedFirstName("Indira", Continent.Asia),
            new ContextualizedFirstName("Shyla", Continent.Asia),
            new ContextualizedFirstName("Lajita", Continent.Asia),
            new ContextualizedFirstName("Guri", Continent.Asia),
            new ContextualizedFirstName("Sunita", Continent.Asia),
            new ContextualizedFirstName("Geeta", Continent.Asia),
            new ContextualizedFirstName("Sunila", Continent.Asia),
            new ContextualizedFirstName("Chandrika", Continent.Asia),
            new ContextualizedFirstName("Shantee", Continent.Asia),
            new ContextualizedFirstName("Urja", Continent.Asia),
            new ContextualizedFirstName("Arundhati", Continent.Asia),
            new ContextualizedFirstName("Kirti", Continent.Asia),

            new ContextualizedFirstName("Louise", Continent.Europe),
            new ContextualizedFirstName("Audrey", Continent.Europe),
            new ContextualizedFirstName("Laurence", Continent.Europe),
            new ContextualizedFirstName("Christine", Continent.Europe),
            new ContextualizedFirstName("Marie", Continent.Europe),
            new ContextualizedFirstName("Nathalie", Continent.Europe),
            new ContextualizedFirstName("Sophie", Continent.Europe),
            new ContextualizedFirstName("Karine", Continent.Europe),
            new ContextualizedFirstName("Ève", Continent.Europe),
            new ContextualizedFirstName("Noëlla", Continent.Europe),
            new ContextualizedFirstName("Sandrine", Continent.Europe),
            new ContextualizedFirstName("Marie-Hélène", Continent.Europe),
            new ContextualizedFirstName("Iris", Continent.Europe),
            new ContextualizedFirstName("Anne-Marie", Continent.Europe),
            new ContextualizedFirstName("Fleur", Continent.Europe),
            new ContextualizedFirstName("Noëlla", Continent.Europe),
            new ContextualizedFirstName("Nicole", Continent.Europe),
            new ContextualizedFirstName("Annabelle", Continent.Europe),
            new ContextualizedFirstName("Anaïs", Continent.Europe),
            new ContextualizedFirstName("Noémie", Continent.Europe),
            new ContextualizedFirstName("Catherine", Continent.Europe),
            new ContextualizedFirstName("Clarence", Continent.Europe),
            new ContextualizedFirstName("Hélène", Continent.Europe),
            new ContextualizedFirstName("Laura", Continent.Europe),
            new ContextualizedFirstName("Lydia", Continent.Europe),
            new ContextualizedFirstName("Emma", Continent.Europe),
            new ContextualizedFirstName("Thaïs", Continent.Europe),
            new ContextualizedFirstName("Mathilde", Continent.Europe),
            new ContextualizedFirstName("Réjane", Continent.Europe),
            new ContextualizedFirstName("Clémence", Continent.Europe),

            new ContextualizedFirstName("Marta", Continent.Europe),
            new ContextualizedFirstName("Tsvetomira", Continent.Europe),
            new ContextualizedFirstName("Valombrosa", Continent.Europe),
            new ContextualizedFirstName("Beonca", Continent.Europe),
            new ContextualizedFirstName("Enrica", Continent.Europe),
            new ContextualizedFirstName("Giovanna", Continent.Europe),
            new ContextualizedFirstName("Gioconda", Continent.Europe),
            new ContextualizedFirstName("Donna-Marie", Continent.Europe),
            new ContextualizedFirstName("Hildagard", Continent.Europe),
            new ContextualizedFirstName("Ulrike", Continent.Europe),
            new ContextualizedFirstName("Allayne", Continent.Europe),
            new ContextualizedFirstName("Carolein", Continent.Europe),
            new ContextualizedFirstName("Jocelynn", Continent.Europe),

            new ContextualizedFirstName("Beata", Continent.Europe),
            new ContextualizedFirstName("Anja", Continent.Europe),
            new ContextualizedFirstName("Maya", Continent.Europe),
            new ContextualizedFirstName("Maëla", Continent.Europe),
            new ContextualizedFirstName("Marija", Continent.Europe),
            new ContextualizedFirstName("Tanja", Continent.Europe),
            new ContextualizedFirstName("Anneke", Continent.Europe),
            new ContextualizedFirstName("Antje", Continent.Europe),
            new ContextualizedFirstName("Heike", Continent.Europe),
            new ContextualizedFirstName("Sofie", Continent.Europe),
            new ContextualizedFirstName("Birgit", Continent.Europe),
            new ContextualizedFirstName("Yarmilla", Continent.Europe),
            new ContextualizedFirstName("Wonnda", Continent.Europe),
            new ContextualizedFirstName("Miri", Continent.Europe),

            new ContextualizedFirstName("Nichelle", Continent.NorthAmerica),
            new ContextualizedFirstName("Nancy", Continent.NorthAmerica),
            new ContextualizedFirstName("Rebecca", Continent.NorthAmerica),
            new ContextualizedFirstName("Julie", Continent.NorthAmerica),
            new ContextualizedFirstName("Vanessa", Continent.NorthAmerica),
            new ContextualizedFirstName("Darlene", Continent.NorthAmerica),
            new ContextualizedFirstName("Naomi", Continent.NorthAmerica),
            new ContextualizedFirstName("Shayna", Continent.NorthAmerica),
            new ContextualizedFirstName("Sarah", Continent.NorthAmerica),
            new ContextualizedFirstName("Emily", Continent.NorthAmerica),
            new ContextualizedFirstName("Shana", Continent.NorthAmerica),
            new ContextualizedFirstName("Zoe", Continent.NorthAmerica),
            new ContextualizedFirstName("Chloe", Continent.NorthAmerica),
            new ContextualizedFirstName("Ella", Continent.NorthAmerica),
            new ContextualizedFirstName("Hailey", Continent.NorthAmerica),
            new ContextualizedFirstName("Karen", Continent.NorthAmerica),
            new ContextualizedFirstName("Jenue", Continent.NorthAmerica),
            new ContextualizedFirstName("Janelle", Continent.NorthAmerica),
            new ContextualizedFirstName("Diantha", Continent.NorthAmerica),
            new ContextualizedFirstName("Lacoya", Continent.NorthAmerica),
            new ContextualizedFirstName("Rondell", Continent.NorthAmerica),
            new ContextualizedFirstName("Davonne", Continent.NorthAmerica),
            new ContextualizedFirstName("Gisbelle", Continent.NorthAmerica),
            new ContextualizedFirstName("Janeese", Continent.NorthAmerica),
            new ContextualizedFirstName("Ronalee", Continent.NorthAmerica),
            new ContextualizedFirstName("Shierlyn", Continent.NorthAmerica),
            new ContextualizedFirstName("Lashae", Continent.NorthAmerica),
            new ContextualizedFirstName("Kaylinn", Continent.NorthAmerica),
            new ContextualizedFirstName("Tandice", Continent.NorthAmerica),
            new ContextualizedFirstName("Candice", Continent.NorthAmerica),
            new ContextualizedFirstName("Danedria", Continent.NorthAmerica),
            new ContextualizedFirstName("Revonda", Continent.NorthAmerica),
            new ContextualizedFirstName("Deloise", Continent.NorthAmerica),
            new ContextualizedFirstName("Errin", Continent.NorthAmerica),
            new ContextualizedFirstName("Jariah", Continent.NorthAmerica),

            new ContextualizedFirstName("Penelope", Continent.SouthAmerica),
            new ContextualizedFirstName("Sierra", Continent.SouthAmerica),
            new ContextualizedFirstName("Dhalia", Continent.SouthAmerica),
            new ContextualizedFirstName("Francesca", Continent.SouthAmerica),
            new ContextualizedFirstName("Valentina", Continent.SouthAmerica),
            new ContextualizedFirstName("Ximena", Continent.SouthAmerica),
            new ContextualizedFirstName("Isabella", Continent.SouthAmerica),
            new ContextualizedFirstName("Renata", Continent.SouthAmerica),
            new ContextualizedFirstName("Valeria", Continent.SouthAmerica),
            new ContextualizedFirstName("Andrijana", Continent.SouthAmerica),
            new ContextualizedFirstName("Camelia", Continent.SouthAmerica),
            new ContextualizedFirstName("Emanuele", Continent.SouthAmerica),
            new ContextualizedFirstName("Maria Eduarda", Continent.SouthAmerica),
            new ContextualizedFirstName("Beatriz", Continent.SouthAmerica),
            new ContextualizedFirstName("Romina", Continent.SouthAmerica),
            new ContextualizedFirstName("Jolanta", Continent.SouthAmerica),
            new ContextualizedFirstName("Carmen", Continent.SouthAmerica),
            new ContextualizedFirstName("Jacynthe", Continent.SouthAmerica),
            new ContextualizedFirstName("Aintzane", Continent.SouthAmerica),
            new ContextualizedFirstName("Yolanda", Continent.SouthAmerica),
            new ContextualizedFirstName("Luzita", Continent.SouthAmerica),
            new ContextualizedFirstName("Manuela", Continent.SouthAmerica),
            new ContextualizedFirstName("Ramohna", Continent.SouthAmerica),
            new ContextualizedFirstName("Reynalda", Continent.SouthAmerica),
            new ContextualizedFirstName("Pepa", Continent.SouthAmerica),
            new ContextualizedFirstName("Roja", Continent.SouthAmerica),
            new ContextualizedFirstName("Neina", Continent.SouthAmerica),
            new ContextualizedFirstName("Maffalda", Continent.SouthAmerica),
            new ContextualizedFirstName("Javiera", Continent.SouthAmerica),
            new ContextualizedFirstName("Delora", Continent.SouthAmerica),
            new ContextualizedFirstName("Estelita", Continent.SouthAmerica),
            new ContextualizedFirstName("Orazia", Continent.SouthAmerica),
            new ContextualizedFirstName("Chiquin", Continent.SouthAmerica),
            new ContextualizedFirstName("Gabriela", Continent.SouthAmerica),
            new ContextualizedFirstName("Lluisa", Continent.SouthAmerica),
            new ContextualizedFirstName("Yanamarie", Continent.SouthAmerica),
            new ContextualizedFirstName("Estefania", Continent.SouthAmerica),
            new ContextualizedFirstName("Pepita", Continent.SouthAmerica),
            new ContextualizedFirstName("Inocenta", Continent.SouthAmerica),
            new ContextualizedFirstName("Cesara", Continent.SouthAmerica),
            new ContextualizedFirstName("Natalita", Continent.SouthAmerica),
            new ContextualizedFirstName("Juanita", Continent.SouthAmerica),
            new ContextualizedFirstName("Soledada", Continent.SouthAmerica),
            new ContextualizedFirstName("Natividad", Continent.SouthAmerica),
            new ContextualizedFirstName("Chiquita", Continent.SouthAmerica),
            new ContextualizedFirstName("Landa", Continent.SouthAmerica),
            new ContextualizedFirstName("Itxaro", Continent.SouthAmerica),
            new ContextualizedFirstName("Racquel", Continent.SouthAmerica),
            new ContextualizedFirstName("Mendi", Continent.SouthAmerica),

            new ContextualizedFirstName("Abigail", Continent.Australia),
            new ContextualizedFirstName("Addison", Continent.Australia),
            new ContextualizedFirstName("Alinta", Continent.Australia),
            new ContextualizedFirstName("Aurora", Continent.Australia),
            new ContextualizedFirstName("Charlotte", Continent.Australia),
            new ContextualizedFirstName("Daisy", Continent.Australia),
            new ContextualizedFirstName("Eleanor", Continent.Australia),
            new ContextualizedFirstName("Olivia", Continent.Australia),
            new ContextualizedFirstName("Grace", Continent.Australia),
            new ContextualizedFirstName("Harper", Continent.Australia),
            new ContextualizedFirstName("Ava", Continent.Australia),
            new ContextualizedFirstName("Alexandra", Continent.Australia),
            new ContextualizedFirstName("Alexis", Continent.Australia),
            new ContextualizedFirstName("Alinta", Continent.Australia),
            new ContextualizedFirstName("Claire", Continent.Australia),
            new ContextualizedFirstName("Eden", Continent.Australia),
            new ContextualizedFirstName("Eleanor", Continent.Australia),
            new ContextualizedFirstName("Elsie", Continent.Australia),
            new ContextualizedFirstName("Evelyn", Continent.Australia),
            new ContextualizedFirstName("Georgia", Continent.Australia),
            new ContextualizedFirstName("Imogen", Continent.Australia),
            new ContextualizedFirstName("Jessica", Continent.Australia),

            new ContextualizedFirstName("Taworri", Continent.Australia),
            new ContextualizedFirstName("Tyipa", Continent.Australia),
            new ContextualizedFirstName("Yamparti", Continent.Australia),
            new ContextualizedFirstName("Kaawa", Continent.Australia),
            new ContextualizedFirstName("Yoyko", Continent.Australia),
            new ContextualizedFirstName("Isley", Continent.Australia),
            new ContextualizedFirstName("Elandra", Continent.Australia),
            new ContextualizedFirstName("Akuna", Continent.Australia),

            new ContextualizedFirstName("Vaiana", Continent.Australia),
            new ContextualizedFirstName("Tahia", Continent.Australia),
            new ContextualizedFirstName("Manutea", Continent.Australia),
            new ContextualizedFirstName("Poe", Continent.Australia),
            new ContextualizedFirstName("Heirani", Continent.Australia),
            new ContextualizedFirstName("Vanina", Continent.Australia),
            new ContextualizedFirstName("Moeata", Continent.Australia),
        };
    }
}

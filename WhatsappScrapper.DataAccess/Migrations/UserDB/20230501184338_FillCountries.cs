using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhatsappScrapper.DataAccess.Migrations.UserDB
{
    /// <inheritdoc />
    public partial class FillCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name", "PhonePrefix" },
                values: new object[,]
                {
                    { 1, "AF", "Afghanistan", "93" },
                    { 2, "AL", "Albania", "355" },
                    { 3, "DZ", "Algeria", "213" },
                    { 4, "AS", "American Samoa", "1684" },
                    { 5, "AD", "Andorra", "376" },
                    { 6, "AO", "Angola", "244" },
                    { 7, "AI", "Anguilla", "1264" },
                    { 8, "AQ", "Antarctica", "672" },
                    { 9, "AG", "Antigua and Barbuda", "1268" },
                    { 10, "AR", "Argentina", "54" },
                    { 11, "AM", "Armenia", "374" },
                    { 12, "AW", "Aruba", "297" },
                    { 13, "AU", "Australia", "61" },
                    { 14, "AT", "Austria", "43" },
                    { 15, "AZ", "Azerbaijan", "994" },
                    { 16, "BS", "Bahamas", "1242" },
                    { 17, "BH", "Bahrain", "973" },
                    { 18, "BD", "Bangladesh", "880" },
                    { 19, "BB", "Barbados", "1246" },
                    { 20, "BY", "Belarus", "375" },
                    { 21, "BE", "Belgium", "32" },
                    { 22, "BZ", "Belize", "501" },
                    { 23, "BJ", "Benin", "229" },
                    { 24, "BM", "Bermuda", "1441" },
                    { 25, "BT", "Bhutan", "975" },
                    { 26, "BO", "Bolivia", "591" },
                    { 27, "BA", "Bosnia and Herzegovina", "387" },
                    { 28, "BW", "Botswana", "267" },
                    { 29, "BV", "Bouvet Island", "" },
                    { 30, "BR", "Brazil", "55" },
                    { 31, "IO", "British Indian Ocean Territory", "246" },
                    { 32, "BN", "Brunei Darussalam", "673" },
                    { 33, "BG", "Bulgaria", "359" },
                    { 34, "BF", "Burkina Faso", "226" },
                    { 35, "BI", "Burundi", "257" },
                    { 36, "KH", "Cambodia", "855" },
                    { 37, "CM", "Cameroon", "237" },
                    { 38, "CA", "Canada", "1" },
                    { 39, "CV", "Cape Verde", "238" },
                    { 40, "KY", "Cayman Islands", "1345" },
                    { 41, "CF", "Central African Republic", "236" },
                    { 42, "TD", "Chad", "235" },
                    { 43, "CL", "Chile", "56" },
                    { 44, "CN", "China", "86" },
                    { 45, "CX", "Christmas Island", "61" },
                    { 46, "CC", "Cocos (Keeling) Islands", "61" },
                    { 47, "CO", "Colombia", "57" },
                    { 48, "KM", "Comoros", "269" },
                    { 49, "CG", "Congo", "242" },
                    { 50, "CD", "Congo, The Democratic Republic of the", "243" },
                    { 51, "CK", "Cook Islands", "682" },
                    { 52, "CR", "Costa Rica", "506" },
                    { 53, "CI", "Cote D\"Ivoire", "225" },
                    { 54, "HR", "Croatia", "385" },
                    { 55, "CU", "Cuba", "53" },
                    { 56, "CY", "Cyprus", "357" },
                    { 57, "CZ", "Czech Republic", "420" },
                    { 58, "DK", "Denmark", "45" },
                    { 59, "DJ", "Djibouti", "253" },
                    { 60, "DM", "Dominica", "1767" },
                    { 61, "DO", "Dominican Republic", "1" },
                    { 62, "EC", "Ecuador", "593" },
                    { 63, "EG", "Egypt", "20" },
                    { 64, "SV", "El Salvador", "503" },
                    { 65, "GQ", "Equatorial Guinea", "240" },
                    { 66, "ER", "Eritrea", "291" },
                    { 67, "EE", "Estonia", "372" },
                    { 68, "ET", "Ethiopia", "251" },
                    { 69, "FK", "Falkland Islands (Malvinas)", "500" },
                    { 70, "FO", "Faroe Islands", "298" },
                    { 71, "FJ", "Fiji", "679" },
                    { 72, "FI", "Finland", "358" },
                    { 73, "FR", "France", "33" },
                    { 74, "GF", "French Guiana", "594" },
                    { 75, "PF", "French Polynesia", "689" },
                    { 76, "TF", "French Southern Territories", "" },
                    { 77, "GA", "Gabon", "241" },
                    { 78, "GM", "Gambia", "220" },
                    { 79, "GE", "Georgia", "995" },
                    { 80, "DE", "Germany", "49" },
                    { 81, "GH", "Ghana", "233" },
                    { 82, "GI", "Gibraltar", "350" },
                    { 83, "GR", "Greece", "30" },
                    { 84, "GL", "Greenland", "299" },
                    { 85, "GD", "Grenada", "1" },
                    { 86, "GP", "Guadeloupe", "590" },
                    { 87, "GU", "Guam", "1671" },
                    { 88, "GT", "Guatemala", "502" },
                    { 89, "GG", "Guernsey", "44" },
                    { 90, "GN", "Guinea", "224" },
                    { 91, "GW", "Guinea-Bissau", "245" },
                    { 92, "GY", "Guyana", "592" },
                    { 93, "HT", "Haiti", "509" },
                    { 94, "HM", "Heard Island and Mcdonald Islands", "" },
                    { 95, "VA", "Holy See (Vatican City State)", "39" },
                    { 96, "HN", "Honduras", "504" },
                    { 97, "HK", "Hong Kong", "852" },
                    { 98, "HU", "Hungary", "36" },
                    { 99, "IS", "Iceland", "354" },
                    { 100, "IN", "India", "91" },
                    { 101, "ID", "Indonesia", "62" },
                    { 102, "IR", "Iran, Islamic Republic Of", "98" },
                    { 103, "IQ", "Iraq", "964" },
                    { 104, "IE", "Ireland", "353" },
                    { 105, "IM", "Isle of Man", "44" },
                    { 106, "IL", "Israel", "972" },
                    { 107, "IT", "Italy", "39" },
                    { 108, "JM", "Jamaica", "1" },
                    { 109, "JP", "Japan", "81" },
                    { 110, "JE", "Jersey", "44" },
                    { 111, "JO", "Jordan", "962" },
                    { 112, "KZ", "Kazakhstan", "7" },
                    { 113, "KE", "Kenya", "254" },
                    { 114, "KI", "Kiribati", "686" },
                    { 115, "KP", "Korea, Democratic People\"S Republic of", "850" },
                    { 116, "KR", "Korea, Republic of", "82" },
                    { 117, "KW", "Kuwait", "965" },
                    { 118, "KG", "Kyrgyzstan", "996" },
                    { 119, "LA", "Lao People\"S Democratic Republic", "856" },
                    { 120, "LV", "Latvia", "371" },
                    { 121, "LB", "Lebanon", "961" },
                    { 122, "LS", "Lesotho", "266" },
                    { 123, "LR", "Liberia", "231" },
                    { 124, "LY", "Libyan Arab Jamahiriya", "218" },
                    { 125, "LI", "Liechtenstein", "423" },
                    { 126, "LT", "Lithuania", "370" },
                    { 127, "LU", "Luxembourg", "352" },
                    { 128, "MO", "Macao", "853" },
                    { 129, "MK", "Macedonia, The Former Yugoslav Republic of", "389" },
                    { 130, "MG", "Madagascar", "261" },
                    { 131, "MW", "Malawi", "265" },
                    { 132, "MY", "Malaysia", "60" },
                    { 133, "MV", "Maldives", "960" },
                    { 134, "ML", "Mali", "223" },
                    { 135, "MT", "Malta", "356" },
                    { 136, "MH", "Marshall Islands", "692" },
                    { 137, "MQ", "Martinique", "596" },
                    { 138, "MR", "Mauritania", "222" },
                    { 139, "MU", "Mauritius", "230" },
                    { 140, "YT", "Mayotte", "262" },
                    { 141, "MX", "Mexico", "52" },
                    { 142, "FM", "Micronesia, Federated States of", "691" },
                    { 143, "MD", "Moldova, Republic of", "373" },
                    { 144, "MC", "Monaco", "377" },
                    { 145, "MN", "Mongolia", "976" },
                    { 146, "MS", "Montserrat", "1664" },
                    { 147, "MA", "Morocco", "212" },
                    { 148, "MZ", "Mozambique", "258" },
                    { 149, "MM", "Myanmar", "95" },
                    { 150, "NA", "Namibia", "264" },
                    { 151, "NR", "Nauru", "674" },
                    { 152, "NP", "Nepal", "977" },
                    { 153, "NL", "Netherlands", "31" },
                    { 154, "AN", "Netherlands Antilles", "599" },
                    { 155, "NC", "New Caledonia", "687" },
                    { 156, "NZ", "New Zealand", "64" },
                    { 157, "NI", "Nicaragua", "505" },
                    { 158, "NE", "Niger", "227" },
                    { 159, "NG", "Nigeria", "234" },
                    { 160, "NU", "Niue", "683" },
                    { 161, "NF", "Norfolk Island", "672" },
                    { 162, "MP", "Northern Mariana Islands", "1670" },
                    { 163, "NO", "Norway", "47" },
                    { 164, "OM", "Oman", "968" },
                    { 165, "PK", "Pakistan", "92" },
                    { 166, "PW", "Palau", "680" },
                    { 167, "PS", "Palestinian Territory, Occupied", "970" },
                    { 168, "PA", "Panama", "507" },
                    { 169, "PG", "Papua New Guinea", "675" },
                    { 170, "PY", "Paraguay", "595" },
                    { 171, "PE", "Peru", "51" },
                    { 172, "PH", "Philippines", "63" },
                    { 173, "PN", "Pitcairn", "870" },
                    { 174, "PL", "Poland", "48" },
                    { 175, "PT", "Portugal", "351" },
                    { 176, "PR", "Puerto Rico", "1787" },
                    { 177, "QA", "Qatar", "974" },
                    { 178, "RE", "Reunion", "262" },
                    { 179, "RO", "Romania", "40" },
                    { 180, "RU", "Russian Federation", "7" },
                    { 181, "RW", "RWANDA", "250" },
                    { 182, "SH", "Saint Helena", "290" },
                    { 183, "KN", "Saint Kitts and Nevis", "1869" },
                    { 184, "LC", "Saint Lucia", "1758" },
                    { 185, "PM", "Saint Pierre and Miquelon", "508" },
                    { 186, "VC", "Saint Vincent and the Grenadines", "1784" },
                    { 187, "WS", "Samoa", "685" },
                    { 188, "SM", "San Marino", "378" },
                    { 189, "ST", "Sao Tome and Principe", "239" },
                    { 190, "SA", "Saudi Arabia", "966" },
                    { 191, "SN", "Senegal", "221" },
                    { 192, "CS", "Serbia and Montenegro", "381" },
                    { 193, "SC", "Seychelles", "248" },
                    { 194, "SL", "Sierra Leone", "232" },
                    { 195, "SG", "Singapore", "65" },
                    { 196, "SK", "Slovakia", "421" },
                    { 197, "SI", "Slovenia", "386" },
                    { 198, "SB", "Solomon Islands", "677" },
                    { 199, "SO", "Somalia", "252" },
                    { 200, "ZA", "South Africa", "27" },
                    { 201, "GS", "South Georgia and the South Sandwich Islands", "" },
                    { 202, "ES", "Spain", "34" },
                    { 203, "LK", "Sri Lanka", "94" },
                    { 204, "SD", "Sudan", "249" },
                    { 205, "SR", "Suriname", "597" },
                    { 206, "SJ", "Svalbard and Jan Mayen", "47" },
                    { 207, "SZ", "Swaziland", "268" },
                    { 208, "SE", "Sweden", "46" },
                    { 209, "CH", "Switzerland", "41" },
                    { 210, "SY", "Syrian Arab Republic", "963" },
                    { 211, "TW", "Taiwan, Province of China", "886" },
                    { 212, "TJ", "Tajikistan", "992" },
                    { 213, "TZ", "Tanzania, United Republic of", "255" },
                    { 214, "TH", "Thailand", "66" },
                    { 215, "TL", "Timor-Leste", "670" },
                    { 216, "TG", "Togo", "228" },
                    { 217, "TK", "Tokelau", "690" },
                    { 218, "TO", "Tonga", "676" },
                    { 219, "TT", "Trinidad and Tobago", "1868" },
                    { 220, "TN", "Tunisia", "216" },
                    { 221, "TR", "Turkey", "90" },
                    { 222, "TM", "Turkmenistan", "993" },
                    { 223, "TC", "Turks and Caicos Islands", "1649" },
                    { 224, "TV", "Tuvalu", "688" },
                    { 225, "UG", "Uganda", "256" },
                    { 226, "UA", "Ukraine", "380" },
                    { 227, "AE", "United Arab Emirates", "971" },
                    { 228, "GB", "United Kingdom", "44" },
                    { 229, "US", "United States", "1" },
                    { 230, "UM", "United States Minor Outlying Islands", "" },
                    { 231, "UY", "Uruguay", "598" },
                    { 232, "UZ", "Uzbekistan", "998" },
                    { 233, "VU", "Vanuatu", "678" },
                    { 234, "VE", "Venezuela", "58" },
                    { 235, "VN", "Viet Nam", "84" },
                    { 236, "VG", "Virgin Islands, British", "1284" },
                    { 237, "VI", "Virgin Islands, U.S.", "1340" },
                    { 238, "WF", "Wallis and Futuna", "681" },
                    { 239, "EH", "Western Sahara", "212" },
                    { 240, "YE", "Yemen", "967" },
                    { 241, "ZM", "Zambia", "260" },
                    { 242, "ZW", "Zimbabwe", "263" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242);
        }
    }
}

﻿using System.Runtime.InteropServices;

namespace CQE.Datas
{
    [StructLayout(LayoutKind.Sequential, Size=1)]
    internal struct DataClass
    {
        public static string[] ResouresNameJapanese;
        public static string[] ResouresNameSimple;
        public static int[] ResouresType;
        public static string[] strMonsterNamesSimple;
        public static string[] strMonsterNamesJapanese;
        public static int[] strMonsterNamesType;
        public static int[] strMonsterHPbase;
        public static int[] strMonsterHPTimes;
        public static byte[] tableA;
        public static string[] BeadNameSimple;
        public static byte[] aaaatobbbb;
        public static string[] strSkillSystem;
        static DataClass()
        {
            ResouresNameSimple = new[] { 
                "------", "Libro Combo 1", "Libro Combo 2", "Libro Combo 3", "Libro Combo 4", "Libro Combo 5", "Guida Organiz.",
                "Guida Trasporto", "Pozione", "Megapozione", "Nutrienti", "Mega Nutrienti", "Antidoto", "Medicina di Erbe",
                "Immunizzatore", "Bev. Energetica", "Supersucco", "Megasucco", "Droga Demoniaca", "Mega Droga dem.",
                "Superpillola", "Pelle Armatura", "Mega Pelle Arm.", "Pillola Armatura", "Bevanda Fresca", "Bevanda Calda",
                "Pulitore", "Deodorante", "Psicosiero", "Pozione Max", "Antica Pozione", "Crist. di Vita", "Polvere di Vita",
                "Catalizzatore", "Tranquillante", "Superamuleto", "Superartiglio", "Amuleto Armatura", "Artiglio Armatura",
                "Carne Cruda", "Carne Avvelenata", "Carne Guasta", "Carne Drogata", "Bist. al Sangue", "Bist. ben Cotta",
                "Carne Bruciata", "Carne Fredda", "Carne Calda", "Pesce Semi-cotto", "Pesce Ben Cotto", "Pesce Bruciato",
                "Uovo Yukumo", "Boomerang", "Coltello Lancio", "Coltello Avv.", "Coltello Sop.", "Coltello Par.",
                "Coltello Tranq.", "Materiale Bomba", "Palla Pittura", "Bomba Lampo", "Bomba Sonica", "Letame",
                "Escrementi Wyvern", "Bomba Letame", "Bomba Fumogena", "Bomba Fum. Vel.", "Teletrasporto", "Bomba Tranq.",
                "Ragnatela", "Rete", "Attrezzo Trapp.", "Trapp. Coperta", "Trapp. a Scossa", "Polvere da Sparo",
                "Barile Piccolo", "Barile Grande", "Bomba Botte Picc.", "Bomba Botte Gr.", "Bomba Botte Gr.+",
                "Bomba a Rimbalzo", "Bomba Felvina", "Bomba Botte JUMP", "Bomba Polytan", "Vecchio Piccone", "Piccone di Ferro",
                "Mega Piccone", "Vecchio Retino", "Retino da Insetti", "Mega Retino", "Spiedo Barbecue", "Cote",
                "Guscio di Bacca", "Involucro d'Osso", "P Normali LV1", "P Normali LV2", "P Normali LV3", "P Perforanti LV1",
                "P Perforanti LV2", "P Perforanti LV3", "P Pallottola LV1", "P Pallottola LV2", "P Pallottola LV3",
                "P Picco LV1", "P Picco LV2", "P Picco LV3", "P Grappolo LV1", "P Grappolo LV2", "P Grappolo LV3", "P Fuoco",
                "P Acqua", "P Tuono", "P Ghiaccio", "P Drago", "P Laceranti", "P Veleno LV1", "P Veleno LV2", "P Paralisi LV1",
                "P Paralisi LV2", "P Sonno LV1", "P Sonno LV2", "P Fatica LV1", "P Fatica LV2", "P Recupero LV1",
                "P Recupero LV2", "P Demone", "P Armatura", "P Tranquillante", "P Pittura", "Nessuna Fiala", "Bottiglia Vuota",
                "Fiala Attacco", "Fiala Rasoio", "Fiala Veleno", "Fiala Paralisi", "Fiala Sonno", "Fiala Fatica",
                "Fiala Pittura", "Verme", "Megamosca Pesca", "Esca Pesce Dorato", "Esca Arrowana", "Grande Esca", "Binocoli",
                "Immondizia", "Flauto", "Flauto Salute", "Flauto Antidoto", "Flauto Demone", "Flauto Armatura", "Miele", "Erba",
                "Erba Antidoto", "Erba Fuoco", "Erba Gelo", "Edera", "Erba Sonno", "Pianta da Linfa", "Felvine",
                "Fiore di Cactus", "Peperoncino", "Frusta Tulipano", "Fungo Blu", "Fungo Nitro", "Fungo Paralisi",
                "Fungo a Ombrello", "Fungo Stimolante", "Fungo Resistenza", "Fungo Drago", "Grande Fungo Par.", "Fungo Piccone",
                "Bacca Pittura", "Superseme", "Seme Armatura", "Seme Elementale", "Seme Drago", "Bacca a Framm.",
                "Bacca ad Ago", "Bacca Aconito", "Bacca Bomba", "Seme Rosso", "Seme Verde", "Zucca Pepipo", "Legno Yukumo",
                "Legno Yukumo+", "Cenere di Qual.", "Sgombro Coltello", "Pesce Sushi", "Pesce Sonno", "Tonno Spillo",
                "Pesce Rombo", "Pesce a Framm.", "Arrowana Scoppio", "Arrowana Bomba", "Pesce Dorato Pcc", "Sardina abissale",
                "Pesce Antico", "Pesce-spada", "Conchiglia Argen.", "Pesce corazzato", "Pelle di Sharq", "Guscio d'Insetto",
                "Larva di Falena", "Gr. Coccinella", "Larva a Serpente", "Insetto Dio", "Insettamaro", "Insetto Lampo",
                "Insetto Tuono", "Insetto Carpent.", "Scaraf. Assass.", "Hercudrome", "Super Ins. Tuono", "Scarabeo Reale",
                "Scarabeo Raro", "Grillo Canterino", "Grande Farfalla", "Pietra", "Min. Ferro", "Cristallo Terra",
                "Min. Machalite", "Min. Pelagicite", "Min. Bealite", "Isisium", "Crist. di Luce", "Min. Dragonite",
                "Frammento di Lava", "Pietra Fuoco", "Min. Carbalite", "Min. Bathycite", "Min. Union", "Gracium",
                "Cella di Fuoco", "Crist. Ghiaccio", "Min. Arcobaleno", "Osso Misterioso", "Teschio Ignoto", "Osso",
                "Osso Mostro Picc.", "Osso Mostro Medio", "Osso Mostro Gr.", "Osso Mostro+", "Osso Affilato",
                "Osso Mostro Duro", "Osso Ucc. Wyvern", "Osso Gigante", "Osso Robusto", "Reliquia Drago", "Zanna Wyvern",
                "Artiglio Wyvern", "Pietra Ucc. Wyv.", "Pietra Wyvern", "Sangue Drago Anz.", "Strillone", "Sacca Veleno",
                "Sacca Tossina", "Sacca Paralisi", "Sacca Immobilizz.", "Sacca Sonno", "Sacca Coma", "Sacca Fuoco",
                "Sacca Inferno", "Sacca Acqua", "Sacca Alluvione", "Sacca Fulmine", "Sacca Ghiaccio", "Sacca Congelante",
                "Superestratto", "Estratto Pallido", "Fluido di Mostro", "Brodo di Mostro", "Piuma di Gagua", "Corno di Kelbi",
                "Pelle Calda", "Pelle Alta Qual.", "Corna di Anteka", "Corazza Rhenoplos", "Carap. Rhenoplos", "Scalpo Rhenoplos",
                "Pelle Zuwaroposu", "Pelle Zuwaroposu+", "Grande Pinna", "Pinna Alta Qual.", "Zanna Affilata", "Pelle Vellutata",
                "Corazza Bnahabra", "Carapace Bnahabra", "Ala Bnahabra", "Pung. Bnahabra", "Mascella Altaroth",
                "Stomaco Altaroth", "Sacca di Qualità", "Pelle Bullfango", "Testa Bullfango", "Pelle Bulldrome",
                "Pelle Bulldrome+", "Zanna Bulldrome", "Scaglia Jaggi", "Scaglia Jaggi+", "Pelle Jaggi", "Zanna Ucc. Wyv.",
                "Pelle Gr. Jaggi", "Pelle Gr. Jaggi+", "Art. Gr. Jaggi", "Art. Gr. Jaggi+", "Collare Regale", "Testa Gr. Jaggi",
                "Scaglia Furogi", "Scaglia Furogi+", "Pelle Furogi", "Zanna Furogi", "Pelle Gr. Furogi", "Pelle Gr. Furogi+",
                "Cor. Gran Furogi", "Carap. Gr. Furogi", "Becco Regale", "Scaglia Baggi", "Scaglia Baggi+", "Pelle Baggi",
                "Pelle Gr. Baggi", "Pelle Gr. Baggi+", "Art. Gr. Baggi", "Art. Gr. Baggi+", "Cresta del Capo", "Pelle Aoashira",
                "Pelle Aoashira+", "Corazza Aoashira", "Carapace Aoashira", "Protez. Aoashira", "Protez. Aoashira+",
                "Pelle Urukususu", "Pelle Urukususu+", "Orecch.Urukususu", "Orecch.Urukususu+", "Addome Urukususu",
                "Addome Urukususu+", "Art. Urukususu", "Art. Urukususu+", "Cor. Rangurotora", "Carap.Rangurotora",
                "Art. Rangurotora", "Art. Rangurotora+", "Plac. Rangurotora", "Scaglia Qurupeco", "Scaglia Qurupeco+",
                "Piuma Qurupeco", "Ala Qurupeco", "Piuma Vivace", "Strano Becco", "Splendido Becco", "Pietra Focaia",
                "Sc. Qurupeco Arc.", "Ala Qurupeco Arc.", "Pietra Tuono", "Pelle Acquatica", "Pelle Acquatica+",
                "Spugna Immatura", "Pelle Spugnosa", "Pelle Spugnosa+", "Sc. Ludroth R.", "Sc. Ludroth R.+", "Art. Ludroth R.",
                "Art. Ludroth R.+", "Cresta Ludroth R.", "Cr. Ludroth R.+", "Coda Ludroth R.", "Pelle Ludroth P.",
                "Sc. Ludroth P.", "Art. Ludroth P.", "Corazza Barroth", "Carapace Barroth", "Spina Barroth", "Spina Barroth+",
                "Art. Barroth", "Art. Barroth+", "Scalpo Barroth", "Coda Barroth", "Fango Fertile", "Cor. Barroth Neve",
                "Spina Barroth N.", "Art. Barroth Neve", "Scalpo Barroth N.", "Coda Barroth Neve", "Palla Muco Gh.",
                "Cor. Hapurubokka", "Carap.Hapurubokka", "Pelle Hapurubokka", "Pelle Hapurubok.+", "Art. Hapurubokka",
                "Art. Hapurubokka+", "Scalpo Hapurubok.", "Fluido Chiaro", "Fluido cangiante", "Pelle Gigginox",
                "Pelle Gigginox +", "Pelle Strana", "Pelle Strana +", "Art. Gigginox", "Art. Gigginox +", "Mascella Terrific",
                "Ghiandola Velen.", "Ghiandola Velen.+", "Pelle Gigginox El", "Art. Gigginox El.", "Scaglia Rathian",
                "Scaglia Rathian +", "Corazza Rathian", "Carapace Rathian", "Membrana Rathian", "Punta Rathian",
                "Punta Rathian+", "Piastra Rathian", "Rubino Rathian", "Sc. Rathian Oro", "Cor. Rathian Oro",
                "Punta Rathian Oro", "Scaglia Rathalos", "Scaglia Rathalos+", "Corazza Rathalos", "Carapace Rathalos",
                "Membrana Rathalos", "Coda Rathalos", "Piastra Rathalos", "Rubino Rathalos", "Sc. Rathalos Arg.",
                "Cor. Rathalos Arg", "Coda Rathalos Arg", "Artiglio Rath", "Midollo Rath", "Midollo Rath+", "Fluido Rath",
                "Corazza Jinouga", "Carapace Jinouga", "Pellicc. Jinouga", "Pellicc. Jinouga+", "Corno Jinouga",
                "Corno Jinouga+", "Art. Jinouga", "Art. Jinouga+", "Coda Jinouga", "Cond. Jinouga", "Cond. Jinouga+",
                "Piastra Jinouga", "Gemma Jinouga", "Scaglia Narga", "Scaglia Narga+", "Pelle Narga", "Pelle Narga+",
                "Coda Narga", "Punta Narga", "Ala Narga", "Ala Narga+", "Zanna Narga", "Zanna Narga+", "Midollo Narga",
                "Mid. All. Narga", "Scaglia Narga V.", "Pelle Narga V.", "Ala Narga V.", "Zanna Narga V.", "Corazza Barioth",
                "Carapace Barioth", "Pelle Barioth", "Pelle Barioth+", "Art. Barioth", "Art. Barioth+", "Punta Barioth",
                "Coda Barioth", "Zanna Barioth", "Zanna Barioth+", "Cor. Barioth Des.", "Pelle Barioth Des", "Art. Barioth Des.",
                "Coda Barioth Des.", "Zanna Ultramarina", "Membrana Pleurica", "Scaglia Uragaan", "Scaglia Uragaan+", "Corazza Uragaan",
                "Carapace Uragaan", "Mascella Uragaan", "Placca Uragaan", "Midollo uragaan", "Rubino Uragaan", "Sc. Uragaan Acc.",
                "Cor. Uragaan Acc.", "Masc. Uragaan Acc", "Pl. Uragaan Acc.", "Corazza Doboru", "Carapace Doboru", "Muschio Doboru", "Muschio Doboru+",
                "Nucleo Doboru", "Coda Doboru", "Coda Doboru+", "Corno Doboru", "Corno Doboru+", "Osso Coda Doboru", "Osso Coda Doboru+", "Scaglia Tigrex",
                "Scaglia Tigrex+", "Corazza Tigrex", "Carapace Tigrex", "Coda Tigrex", "Art. Tigrex", "Art. Tigrex+", "Zanna Tigrex", "Zanna Tigrex+",
                "Scalpo Tigrex", "Agito Tigrex", "Scaglia Tigrex Nr", "Corazza Tigrex Nr", "Art. Tigrex Nr.", "Zanna Tigrex Nr.", "Corazza Diablos",
                "Carapace Diablos", "Spina Diablos", "Spina Diablos+", "Coda Diablos", "Zanna Diablos", "Corno Contorto", "Corno Maestoso", "Midollo Diablos",
                "Mid. All. Diablos", "Cor. Diablos Nr.", "Spina Diablos Nr.", "Corno Diablos Nr.", "Scaglia Uroktor", "Scaglia Uroktor+", "Scaglia Agnaktor",
                "Corazza Agnaktor", "Carapace Agnaktor", "Pelle Agnaktor", "Pelle Agnaktor+", "Art. Agnaktor", "Art. Agnaktor +", "Pinna Agnaktor",
                "Pinna Agnaktor +", "Becco Agnaktor", "Coda Agnaktor", "Corazza Fusa", "Carapace Fuso", "Cor. Agnaktor Gh.", "Pelle Agnaktor Gh",
                "Art. Agnaktor Gh.", "Pinna Agnaktor Gh", "Becco Agnaktor Gh", "Coda Agnaktor Gh.", "Corazza Umida", "Corazza Mohran", "Carapace Mohran",
                "Scaglia Mohran", "Scaglia Mohran+", "Protez. Mohran", "Protez. Mohran+", "Zanna Robusta", "Zanna Robusta+", "Gemma Drago Terra",
                "Scaglia Deviljho", "Pelle Deviljho", "Zanna Deviljho", "Art. Deviljho", "Scalpo Deviljho", "Coda Deviljho", "Saliva Deviljho", "Gemma Deviljho",
                "Scaglia Akantor", "Corazza Akantor", "Coda Akantor", "Art. Akantor", "Zanna Akantor", "Punta Akantor", "Gemma Akantor", "Corazza Ukanlos",
                "Scaglia Ukanlos", "Coda Ukanlos", "Art. Ukanlos", "Pala Ukanlos", "Pinna Ukanlos", "Gemma Ukanlos", "Placca Alatreon", "Piastra Alatreon",
                "Art. Alatreon", "Membrana Alatreon", "Coda Alatreon", "Foracielo Rotto", "Foracielo", "Gemma Drago Azz.", "Carapace Amatsu", "Membrana Amatsu",
                "Corno Amatsu", "Artiglio Amatsu", "Coda Amatsu", "Petto Amatsu", "Sacca Tempesta", "Gemma Drago Div.", "Scheggia Ruggine", "Scheggia Antica",
                "Pietra Ruggine", "Framm. Ant. Gr.", "Framm. Ant. Pcc.", "Framm. Ant. Lungo", "Uovo di Ferro", "Uovo d'Argento", "Uovo d'Oro", "Encomio", "Encomio G",
                "Bollo a Impronta", "Buono Yukumo", "Buono Bevanda", "Buono Terme", "Buono Comp.Felyne", "Buono Anz. Veg.", "Buono Anz. Veg.+", "Buono Anz.Veg.Br.",
                "Buono Anz.Veg.Arg", "Buono Anz.Veg.Oro", "Codice Arma", "Codice Balestra", "Codice Spada", "Chiamata Armi", "Att. Forza Terr.", "Att. Forza Giglio",
                "Ant. Zanna Mist.", "Lo Spadacc.Magico", "Prova Rag. Detect", "Contratto Negima", "Buono Rivista", "Buono Tesoro J", "Buono Pirata J",
                "Buono Leggenda J", "Gatto d'Oro Pir.J", "Buono Famitsu", "Famitsu ST", "Famitsu GT", "Famitsu PT", "Gatto Ovale Fam.", "Buono Dengeki",
                "Buono Dengeki G", "Titolo Big Boss", "Cartone Confidenz", "Buono UNIQLO", "Buono Gemma Nera", "Buono Corv.Bianco", "Buono Pelle Wyv.",
                "Buono Mafumofu", "Diario Caldo", "Notifica Monhanbu", "Info Lynian", "Info Insetti", "Info Delex", "Info Erbivori", "Info Ucc. Wyv. 1",
                "Info Ucc. Wyv. 2", "Info Pelagus", "Info Wyv. Brut.1", "Info Wyv. Brut.2", "Info Doboruberuku", "Info Deviljho", "Info Leviathan 1",
                "Info Leviathan 2", "Info Hapurubokka", "Info Wyvern 1", "Info Wyvern 2", "Info Akantor", "Info Ukanlos",
                "Info Jinouga", "Info Jhen Mohran", "Info Amatsu", "Info Alatreon", "Mappa", "Cass. Primo Socc.",
                "Razione", "Spiedo Portatile", "Mini Cote", "Buono Pass Zampa", "Trapp. Sc. Scorta", "Bomba Lampo Scrt.",
                "Bomba Sonica Sc.", "Pozione Max Sc.", "Trapp. Cop. Sc.", "BombaBotteGr. Sc.", "Bomba Antidrago",
                "P Balista", "Balista Bloccante", "Elast. Bloccante", "Miele Reale", "Fungo Speciale", "Fungo Scelto",
                "Fungo Maturo", "Fungo Delicato", "Germogli Bambù", "Pianta Aurora", "Bacca Pepe Vulc.", "Pesce Dorato",
                "Pesce Argentato", "Pesce Broccato", "Pesce Brocc.Reale", "Rhino Reale", "Rhino Divino",
                "Grillo Argentato", "Grillo Dorato", "Pepita d'Oro Pcc.", "Pepita d'Oro", "Pietra-Fiore Pcc.",
                "Pietra-Fiore", "Osso di Cristallo", "Osso Dorato", "Pietra Sangue", "Pietra Sanguigna", "Carbone",
                "Carbone AltoRend.", "P Cannone", "Uovo Wyvern", "Uovo Erbivoro", "Uovo Gagua", "Uovo Gagua Dorato",
                "Pietra Polvere", "Pietra Fuliggine", "Letame Gagua", "Fegato Bianco", "Olio Zuwaroposu", "Lingua di Popo",
                "Borsa Segreta", "Ghianda Attraente", "Borsa Pura", "Borsa Brillante", "Estratto Giggi", "Fegato di Delex",
                "Lacrime Wyvern", "Pianto Wyvern", "Lacrime di Bestia", "Pianto di Bestia", "Scarti Legno", 
                "Scarti Legno+", "Scarti Zucca", "Scarti Ferro", "Scarti Ferro+", "Scarti Osso", "Scarti Osso+", 
                "Scarti Pellicc.", "Scarti Pellicc.+", "Scarti Rhenoplos", "Scarti Rhenoplos+", "Scarti Zuwaroposu", 
                "Scarti Zuwarop. +", "Scarti Scaraf.+", "Scarti Scaraf.+", "Scarti Altaroth", "Scarti Altaroth+", 
                "Scarti Bulldrome", "Scarti Bulldrome+", "Scarti Jaggi", "Scarti Jaggi+", "Scarti Furogi", 
                "Scarti Furogi+", "Scarti Baggi", "Scarti Baggi+", "Scarti Aoashira", "Scarti Aoashira+", "Scarti Urukususu", 
                "Scarti Urukususu+", "Scarti Ranguro", "Scarti Ranguro+", "Scarti Qurupeco", "Scarti Qurupeco+",
                "Scarti Ludroth", "Scarti Ludroth+", "Scarti Barroth", "Scarti Barroth+", "Scarti Hapuru", 
                "Scarti Hapuru+", "Scarti Gigginox", "Scarti Gigginox+", "Scarti Rathian", "Scarti Rathian+", 
                "Scarti Rathalos", "Scarti Rathalos+", "Scarti Jinouga", "Scarti Jinouga+", "Scarti Nargacuga", 
                "Scarti Nargacuga+", "Scarti Barioth", "Scarti Barioth+", "Scarti Uragaan", "Scarti Uragaan+", 
                "Scarti Doboru", "Scarti Doboru+", "Scarti Tigrex", "Scarti Tigrex+", "Scarti Diablos", "Scarti Diablos+",
                "Scarti Agnaktor", "Scarti Agnaktor+", "Scarti Mohran", "Scarti Mohran+", "Scarti Deviljho", 
                "Scarti Akantor", "Scarti Ukanlos", "Scarti Alatreon", "Scarti Amatsu", "Scarti Valore", "Scarti Valore+",
                "Pietra Armatura", "Sfera Armatura", "Sfera Armatura+", "Sfera Arm. Dura", "Sfera Arm. Pes.", 
                "Amuleto Mistero", "Amuleto Brillante", "Amuleto Consunto", "Gioiello Suiko", "Gioiello Akito",
                "Gll Campo Batt.", "Gll Lapislazzuli"
            };

            ResouresType = new[] { 
                0, 8, 8, 8, 8, 8, 0, 0, 15, 15, 15, 14, 15, 15, 15, 15, 
                10, 10, 10, 10, 10, 10, 10, 10, 15, 15, 14, 14, 14, 10, 10, 14, 
                15, 14, 14, 8, 8, 8, 8, 14, 15, 15, 15, 14, 14, 0, 10, 10, 
                11, 10, 0, 11, 11, 11, 11, 11, 11, 11, 14, 15, 8, 8, 9, 9, 
                10, 10, 10, 11, 10, 9, 8, 9, 8, 8, 14, 15, 15, 11, 11, 8, 
                10, 10, 10, 10, 14, 14, 12, 14, 14, 12, 8, 9, 15, 15, 10, 10, 
                10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 
                10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 
                10, 0, 10, 10, 10, 10, 10, 10, 10, 10, 15, 15, 14, 14, 14, 12, 
                0, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 
                15, 5, 15, 15, 15, 15, 15, 15, 15, 5, 5, 15, 15, 15, 15, 15, 
                15, 15, 15, 15, 13, 13, 5, 5, 0x11, 1, 15, 7, 15, 15, 15, 15, 
                15, 15, 7, 15, 1, 1, 1, 1, 5, 5, 13, 13, 15, 15, 15, 15, 
                15, 5, 5, 5, 4, 0x11, 0x11, 1, 1, 15, 15, 15, 15, 5, 5, 5, 
                5, 5, 5, 5, 0x11, 0x11, 0x11, 0x11, 0x11, 13, 5, 15, 5, 15, 15, 14, 
                12, 4, 4, 0x10, 0x10, 4, 0x10, 0x11, 14, 14, 0x10, 20, 4, 12, 4, 0x10, 
                4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 0x10, 4, 0x10, 12, 12, 4, 0x10, 4, 
                12, 4, 0x10, 4, 4, 0x10, 4, 4, 0x10, 4, 0x10, 4, 4, 5, 0x10, 13, 
                15, 4, 4, 0x10, 4, 4, 4, 0x10, 4, 4, 0x10, 4, 14, 4, 0x10, 4, 
                0x10, 4, 0x10, 4, 0x10, 4, 14, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 4, 
                0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 
                4, 0x10, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 0x10, 4, 0x10, 4, 0x10, 
                0x10, 0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 0x10, 
                0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 4, 4, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 
                4, 0x10, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 
                4, 0x10, 0x10, 0x10, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 0x10, 0x10, 0x10, 
                4, 0x10, 4, 0x10, 4, 4, 4, 0x10, 0x10, 0x10, 0x10, 4, 4, 0x10, 0x10, 4, 
                0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 
                4, 4, 4, 0x10, 4, 0x10, 4, 0x10, 0x10, 0x10, 0x10, 0x10, 4, 0x10, 4, 0x10, 
                4, 0x10, 4, 4, 4, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 4, 0x10, 4, 0x10, 
                4, 0x10, 4, 0x10, 0x10, 0x10, 0x10, 0x10, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 
                0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 4, 0x10, 4, 0x10, 4, 0x10, 0x10, 0x10, 
                0x10, 0x10, 4, 0x10, 4, 0x10, 4, 4, 4, 0x10, 4, 0x10, 0x10, 0x10, 0x10, 4, 
                0x10, 4, 4, 0x10, 4, 0x10, 4, 0x10, 4, 0x10, 4, 4, 4, 0x10, 0x10, 0x10, 
                0x10, 0x10, 0x10, 0x10, 0x10, 4, 0x10, 4, 0x10, 4, 20, 4, 0x10, 0x10, 0x10, 0x10, 
                0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 
                0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 
                0x10, 0x10, 0x10, 0x10, 5, 0x11, 4, 0x10, 0x10, 0x10, 4, 4, 4, 4, 0x10, 4, 
                0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0, 0, 0, 4, 4, 4, 4, 
                4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 
                4, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11, 11, 
                11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 2, 11, 10, 10, 1, 1, 
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 
                1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 5, 5, 5, 0x11, 0x10, 5, 5, 0x11, 5, 5, 0x11, 0x11
             };
            strMonsterNamesSimple = new[] {"------","Rathian","Rathalos","Qurupeco","Gigginox","Barioth","Diablos","Deviljho","Barroth","Uragaan",
                                        "Jaggi","Jaggia","Gran Jaggi","Baggi","Gran Baggi","Rathian Dorata","Ludroth Reale","Ludroth","Rathalos Argento","Agnaktor",
                                        "Diablos Nero","Uroktor","Delex","Tigrex Nero","Albatrion","Jhen Mohran","Giggi","Aptonoth","Popo","Rhenoplos",
                                        "Felyne","Melynx","Nargacuga Verde","Altaroth","Kelbi","Uova Giggi","Bnahabra","Bnahabra (Terra)","Bnahabra (Ghiaccio)","Bnahabra (Fuoco)",
                                        "Jinouga","Amatsu Magatsuhi","Aoashira","Urukususu","Rangurotora","Gran Furogi","Doboroberuku","Hapurubokka","Furogi","Zuwaruposu",
                                        "Gagua","Qurupeco Arcobaleno","Gigginox Tuono","Barioth Desertico","Barioth (Ghiaccio)","Uragaan Acciaio","Ludroth Porpora","Agnaktor Ghiacciato","Tigrex","Nargacuga",
                                        "Akantor","Ukanlos","Bulldrome","Bullfango","Anteka","Gatto Supporto","Gatto Trasporti","Anziano Vegetali","Zuwalopreruposu (Fuoco)","Pietra",
                                        "Pietra (Sabbia)","Pietra (Acqua)","Pietra (Ghiaccio)","Pietra (Fuoco)","Pietra (Montagna)"
            };

            strMonsterNamesType = new[] { 
                0xff, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 
                1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 
                1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 
                0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 
                0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0
             };
            strMonsterHPbase = new[] { 
                0x2d, 0x26, 0x26, 0x2a, 0x26, 40, 0x37, 40, 0x2b, 20, 0x21, 0x2d, 40, 40, 0x2e, 40, 
                0x2d, 70, 130, 0x26, 50, 0x5e, 20, 0x20, 30, 0x19, 0x42, 40, 40, 0x2c, 0x26, 0x2a, 
                0x29, 0x2a, 0x30, 50, 0x2a, 90, 90, 0x12
             };
            strMonsterHPTimes = new[] { 
                0, 13, 15, 0x12, 20, 0x17, 0x19, 0x1c, 30, 0x21, 0x23, 0x26, 40, 0x2b, 0x2d, 0x30, 
                50, 0x35, 0x38, 60, 0x3f, 0x42, 70, 0x49, 0x4c, 80, 0x55, 90, 100, 0x69, 0x6c, 110, 
                0x70, 0x73, 0x75, 120, 0x7b, 0x7f, 130, 0x87, 140, 0x90, 0x94, 0x98, 0x9c, 160, 0xa4, 170, 
                0xaf, 180, 0xb9, 190, 200, 210, 220, 230, 240, 250, 260, 270, 280, 290, 300, 310
             };
            tableA = new byte[] { 
                0xd8, 0x8e, 0x62, 0x52, 0x41, 0x38, 0xf4, 0x6a, 0x3b, 0xed, 0x97, 0x27, 0xb1, 0x75, 0x7c, 0xad, 
                0x7e, 0x5d, 30, 20, 0x84, 0xde, 0xb5, 0x74, 0x4f, 0x3a, 0xd7, 0xc5, 0xee, 40, 0xec, 0x2c, 
                0xae, 0xd5, 0x30, 200, 0x3d, 0xcf, 0xbf, 0x4a, 90, 8, 0x2a, 160, 0x11, 0x15, 0x88, 0x65, 
                0x54, 0xaf, 0xab, 0xdd, 0xf1, 0xfd, 0x1c, 0x2f, 0xb6, 0xfe, 0x6f, 0xa6, 0xfb, 0x4e, 0x94, 0xe0, 
                0x44, 0xc4, 120, 0x1a, 0x48, 0x10, 0x37, 0xb3, 0x23, 0x66, 0x68, 0x87, 0xd3, 0x3e, 0xca, 0x21, 
                0xea, 0xcd, 0xa5, 0xda, 0xc6, 0xf3, 0x8f, 0x33, 0xc3, 0xa9, 0xe4, 0xd1, 0xc1, 0x93, 0x98, 0xb2, 
                0xac, 0xc0, 0xa3, 0x7b, 0, 0x2e, 0x7a, 0x5c, 0x25, 0x9e, 0x72, 0x89, 0xe3, 0xf6, 0xe2, 0x1b, 
                0xf7, 0xbb, 0x2b, 0x7d, 0xf8, 0x95, 130, 0x22, 0x26, 0x4c, 100, 0x85, 0x19, 0xf2, 0xff, 0x4b, 
                0x5e, 0x69, 0x47, 0x6b, 0xe8, 0x34, 0xc7, 0x5b, 0x7f, 0xce, 0x36, 0x40, 0x99, 0x63, 0xd0, 0x43, 
                0x70, 0x91, 0x13, 0x17, 140, 0x16, 0xe5, 0x18, 7, 0x3f, 0x9a, 0xf5, 0xa1, 0x24, 0xb0, 0x4d, 
                0x31, 0x92, 0x1d, 0x6d, 0x83, 0x5f, 210, 150, 4, 0xa7, 70, 0x56, 11, 0xcc, 0xc9, 0x12, 
                0x67, 0xfc, 0x8a, 0x81, 0x35, 0x9f, 3, 0xef, 170, 220, 0xdf, 0x20, 0xe1, 0x77, 110, 0x51, 
                0xbc, 190, 0xa4, 0x61, 0xa2, 0xb8, 0xb7, 0x6c, 0x71, 13, 0xa8, 0x53, 10, 230, 0x90, 0x59, 
                1, 0x29, 6, 0xf9, 12, 0xbd, 60, 0xba, 0xdb, 0x1f, 0x76, 250, 180, 2, 0xb9, 0xd4, 
                0x8d, 0x45, 0x73, 14, 0xd9, 0x79, 50, 0xe9, 0x39, 0x86, 0x49, 240, 0xcb, 15, 0x2d, 0x55, 
                0xeb, 0xd6, 0x57, 0x9b, 5, 9, 0xc2, 0x60, 0x58, 0x8b, 0x9c, 0x80, 80, 0x9d, 0xe7, 0x42
             };
            BeadNameSimple = new[] { 
                "O", "Gll Risoluto  [1]", "Gll Risoluto  [1]", "Gll Paralisi  [1]", "Gll Anti-par  [2]", "Gll Vigore    [1]", "Gll Scossa    [2]",
                "Gll Antidoto  [1]", "Gll Anti-Vel  [2]", "Gll ForzAnim  [1]", "Gll Anti-Furto[1]", "Gll Lubrific. [1]", "Gll Nev.&Fang.[1]",
                "Gll Retrovir. [1]", "Gll Antiviral.[1]", "Gll Ancora    [1]", "Gll Tettonica [1]", "Gll BrezzaCald[1]", "Gll BrezzaFrsc[1]",
                "Gll Tpp Orec. [1]", "Gll Silenzio  [3]", "Gll Fermacarte[1]", "Gll Metal.Pes.[2]", "Gll Attacco   [1]", "Gll Fierezza  [2]",
                "Gll Fortissimo[3]", "Gll Esperto   [1]", "Gll Celebrità [2]", "Gll Eremita   [3]", "Gll Att.Spec. [1]", "Gll Att.Spec.+[2]",
                "Gll Elemento  [1]", "Gll Elemento +[3]", "Gll Att.Fuoco [1]", "Gll Att.Fuoco+[2]", "Gll Att.Acqua [1]", "Gll Att.Acqua+[2]",
                "Gll Att.Tuono [1]", "Gll Att.Tuono+[2]", "Gll Att.Ghiac.[1]", "Gll Att.Ghiac+[2]", "Gll Att.Drago [1]", "Gll Att.Drago+[2]",
                "Gll Debilitat.[1]", "Gll Debilitat+[3]", "Gll Colpo Pes.[1]", "Gll Colpo Pes+[3]", "Gll Munizioni [1]", "Gll Munizioni+[3]",
                "Gll CaricaCort[1]", "Gll CaricaRap.[3]", "Gll Rilasc.Frz[1]", "Gll Rilasc.F.+[2]", "Gll KO        [1]", "Gll KO +      [2]",
                "Gll Fatica    [1]", "Gll Fatica +  [2]", "Gll Pericolo  [1]", "Gll Crisi     [2]", "Gll Avversità [1]", "Gll Avversità+[2]",
                "Gll Bombardier[1]", "Gll Piffero   [1]", "Gll Obice     [1]", "Gll Difesa    [1]", "Gll Tartaruga [2]", "Gll Rovina    [1]",
                "Gll Rovina +  [3]", "Gll Inferno   [1]", "Gll Cremisi   [1]", "Gll Ruscello  [1]", "Gll Torrente  [1]", "Gll Fulmine   [1]",
                "Gll Tuono     [1]", "Gll Gelo      [1]", "Gll Ghiacciaio[1]", "Gll Uccisore  [1]", "Gll Estinzione[1]", "Gll Protezione[1]",
                "Gll Prot.Divin[1]", "Gll Forza     [1]", "Gll Benessere [1]", "Gll Rec.Veloce[2]", "Gll Permanenza[1]", "Gll Eterno    [2]",
                "Gll Evasione  [1]", "Gll Schivata  [2]", "Gll Salto     [1]", "Gll Volante   [3]", "Gll Rinforder.[1]", "Gll Rinforder+[2]",
                "Gll MaestrTrap[1]", "Gll Mangiavel.[1]", "Gll Ingordigia[3]", "Gll Maratona  [1]", "Gll Scattista [3]", "Gll Costituz. [1]",
                "Gll Salute    [2]", "Gll PrendFiato[1]", "Gll Rec.Resist[2]", "Gll Digiuno   [1]", "Gll Ciccione  [1]", "Gll Fato      [1]",
                "Gll Destino   [3]", "Gll Premio    [1]", "Gll Premio +  [3]", "Gll Tagliapel.[1]", "Gll Scalco    [3]", "Gll Viag.Zaino[1]",
                "Gll Raccolta  [1]", "Gll Raccolta+ [1]", "Gll BuonaFort.[1]", "Gll Amicizia  [1]", "Gll Amato     [2]", "Gll Psichico  [1]",
                "Gll Professore[1]", "Gll MaestrComb[1]", "Gll Tenacia   [1]", "Gll Mappa     [1]", "Gll Bmb Letame[1]", "Gll Cacciatore[1]",
                "Gll Ninja     [1]", "Gll Artigiano [1]", "Gll Maestro   [3]", "Gll Schermid. [1]", "Gll Spadaccino[3]", "Gll Rasoio    [1]",
                "Gll Taglierino[3]", "Gll SfilaSpada[1]", "Gll Sguainat. [2]", "Gll EstrContu.[1]", "Gll EstrContu+[3]", "Gll MuroPietra[1]",
                "Gll Cort.Ferro[2]", "Gll Muro Duro [1]", "Gll Muraglione[2]", "Gll Mulino    [1]", "Gll ColpoForte[1]", "Gll ColpForte+[3]",
                "Gll Foro      [1]", "Gll Foro +    [3]", "Gll Pallottola[1]", "Gll Pallott. +[3]", "Gll ColpoBonus[1]", "Gll ColpBonus+[2]",
                "Gll ForoBonus [1]", "Gll Pall.Bonus[1]", "Gll PiccoBonus[1]", "Gll FrammBonus[1]", "Gll Tagl.Bonus[1]", "Gll FuocoCont.[1]",
                "Gll Raffica   [3]", "Gll Mattiniero[1]", "Gll AltaVeloc.[2]", "Gll SenzaRinc.[1]", "Gll SenzaScos.[3]", "Gll Cecchino  [1]",
                "Gll SostParal.[1]", "Gll SostParla.[2]", "Gll SostSonno [1]", "Gll SostVeleno[1]", "Gll SostAttac.[1]", "Gll SostAtt.+ [2]",
                "Gll SostRasoio[1]", "Gll SostFatica[1]"
             };
            aaaatobbbb = new byte[] { 
                0xef, 0x13, 0x58, 0xdf, 0xcf, 0x2a, 0xba, 0x6f, 0xb2, 0x84, 0x68, 0xd7, 0xea, 0x5c, 0x24, 0x31, 
                0xa8, 0xb9, 180, 0x10, 0x39, 0xb3, 0x48, 0xca, 0xce, 0xd4, 8, 0xf5, 0x57, 210, 0x2d, 0xf3, 
                0xa6, 0xc1, 0x66, 3, 0x4f, 0x29, 6, 0x98, 0x79, 0x8a, 0xbf, 0xaf, 190, 0xe9, 0xc7, 0xd9, 
                0xa4, 0x97, 5, 0x1a, 0xf9, 0x67, 0xbd, 0x95, 0x7f, 0x7d, 9, 0xad, 0xe2, 0x55, 0x4a, 0x49, 
                0x45, 0xe7, 0x90, 0x4d, 0x1b, 1, 0x60, 0xf4, 0x54, 0x4c, 0x6c, 0xd8, 0x19, 0x11, 13, 80, 
                0x62, 0x83, 0xc9, 0xf6, 0x30, 0xd3, 0x37, 0xb0, 30, 0x77, 0xee, 0x70, 0x7c, 0xbb, 0xe4, 15, 
                0xa3, 0xd5, 0x18, 0x72, 0x44, 0x3d, 0xf8, 0x9e, 0x2e, 0x51, 10, 140, 0x5f, 0x2f, 0x42, 0x9c, 
                0x2b, 0xfe, 0xc3, 0x5e, 0x74, 0x26, 0x22, 0x12, 0xc4, 0x73, 0x25, 0xfb, 0x4b, 0x85, 0x6d, 0xe0, 
                0x92, 0x81, 0xec, 0x80, 0xab, 0x9f, 0x1f, 0xac, 0xdd, 0xe8, 0xd0, 0xed, 14, 0xc6, 0x6a, 0xe3, 
                0x56, 0x93, 0x76, 0x8f, 0x36, 40, 0xe1, 0x52, 0xd1, 60, 0xd6, 0x94, 130, 0xb7, 0x8d, 200, 
                250, 0xc0, 0x9d, 0x88, 0x99, 0x3b, 0x27, 0x3a, 0x20, 230, 0x91, 0x1d, 0x47, 2, 0x1c, 0x15, 
                0x23, 0xda, 0xb6, 0xcd, 100, 0xa1, 0xf2, 240, 0xb8, 0x21, 0x40, 0x34, 90, 0xa2, 0xff, 0x87, 
                0x16, 0x35, 0x4e, 160, 150, 0x41, 0x65, 0xcc, 0x38, 0xa7, 0xdb, 0x86, 110, 0xa9, 0x5d, 0xbc, 
                0x9a, 12, 0x53, 0x6b, 0x8b, 0xae, 0x75, 0xfd, 0x7b, 170, 0xeb, 0x71, 0x17, 120, 4, 0x89, 
                0, 0xe5, 0xf7, 0xb5, 0xb1, 0xc5, 11, 0x2c, 7, 0x3f, 0xa5, 50, 0x59, 0x5b, 0xde, 220, 
                0x9b, 0xc2, 0x69, 0x63, 0x33, 0x8e, 0x7e, 70, 0xfc, 0x7a, 0xcb, 0x43, 0x3e, 0xf1, 20, 0x61
             };
            strSkillSystem = new[] { 
                "-", "Torso Aumentato", "Veleno", "Paralisi", "Sonno", "KO", "Fango/Neve", "Furtività", "Salute", "Vel.Rec.", "Acutezza", "Artigiano",
                "ESP", "Esperto", "Aff.Rapido", "Guardia", "Guard. Aum", "Auto-Guard", "Ricar. vel", "Rinculo", "P Norm aum", "P Perf aum", "P Pall aum",
                "Agg.P Norm", "Agg.P Perf", "Agg.P Pall", "Agg.P Picc", "Agg.P Grap", "Status", "Elemento", "Frz Bmb su", "Fame", "Golosità", "Attacco",
                "Difesa", "Protezione", "Prot.Udito", "Anti-Ladro", "Ampia Area", "ViaggZaino", "Res.Fuoco", "Res.Acqua", "Res.Tuono", "Res.Ghiac",
                "Res.Drago", "Res.Caldo", "Res.Freddo", "Anti Vento", "Raccolta", "Vel. Racc.", "Capriccio", "Fato", "Psichico", "Recupero", "% Combo",
                "Esp Combo", "Evasione", "Potenziale", "Eterno", "Resistenza ", "Capacità", "Precisione", "Cucina", "Scalco", "Res.Terr.", "Dist.Evas.",
                "Estr.Crit.", "Piaz.Rapid", "Costituz.", "Tranquill.", "Percezione", "Carica Rap", "Estr.Stord", "Res. Attr.", "Soppraviss", "FuocoRapid",
                "MaestLetam", "Antisett.", "F.VelenAgg", "F.ParalAgg", "F.SonnoAgg", "F.AttacAgg", "F.RasoiAgg", "Corno", "Artigliere", "Risveglio",
                "Cacciatore", "ForzAnima", "Att. Fuoco", "Att. Acqua", "Att. Tuono", "Att. Ghiac", "Att. Drago", "P.TagliAgg", "P.FaticAgg", "ColpoGrave",
                "ColpoPesante", "Stordimento", "Att.Fatica", "Rinfoderat", "Rec.Energ."
             };
        }
    }
}

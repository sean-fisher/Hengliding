﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamesList
{

    static string[] henNames = {"Scottbert", "Snufgito", "Henrah", "Dackfred", "Homemer", "Premin", "Seanby", "Oranifer", "Algito", "Jobone", "Snufsuke", "Oramin", "Henfred", "Leomin", "Prekin", "Her", "Na", "Kocure", "Hooy", "El", "Leopy", "Home", "Jacksuke", "Jackjo", "Leojo", "Ko", "Jopy", "Fredson", "Orason", "Oranard", "Fnordjo", "Seangold", "Ora", "Fnordba", "Elby", "Hencure", "Elsuke", "Benkin", "Pickleby", "Orapor", "Picklejo", "Bumfice", "Kentaro", "The Fredbone", "Bonepy", "Scottjo", "Fnordrah", "Soni", "Jackcure", "Homesuke", "Elcure", "Seangito", "Nay", "Napor", "Benson", "Kevgito", "Sasuke", "Elgold", "Sean", "Namer", "Hoopy", "Him", "Ben", "Leofice", "The Konathan", "Bone", "Kevneth", "Hoonathan", "Moorah", "Scar", "Preby", "Homegold", "Oragold", "Hooruto", "Kugito", "Boneseph", "Snufbert", "Jorah", "Leogito", "Dacksuke", "Boneiam", "Orataro", "Hoogold", "Grogpor", "Homepy", "Ku", "Fnordpy", "Benpor", "Herbone", "Seanbone", "Alnge", "Alfice", "Fredgold", "Homeseph", "Leo", "Himsmelda", "Seanjo", "Gibnge", "Koiam", "Scargold", "Hersuke", "Bonemin", "Bumfred", "Bumnifer", "Themruto", "Elrick", "Bumsuke", "Fnordrick", "Bengito", "Leoseph", "Bumba", "Eggnard", "Bonenathan", "Orakin", "Kutaro", "Henpy", "Fredpor", "Fredgito", "Scottfice", "Delltaro", "Boneba", "Keniam", "Koson", "Jackson", "Grogson", "Alby", "Orange", "Kenseph", "Homejo", "Jonathan", "Snuf", "Kenfice", "Fnordfred", "Snufba", "Bum", "Elbone", "Picklegold", "Dellbone", "Kopor", "Themjo", "Dackpor", "Himruto", "Jacknathan", "Alruto", "Henba", "Homey", "Kevbert", "Narick", "Themnathan", "Himmin", "Scargito", "Moosmelda", "Scott", "Kukin", "Scottba", "Jocure", "Grogrick", "Scottby", "Picklepy", "Fredjo", "Scarpy", "Nasmelda", "Hen", "Kevby", "Jackbone", "Kevpy", "Seany", "Grog", "Themmer", "Homesmelda", "Snufy", "Elgito", "Naiam", "Dellmin", "Jofice", "Kevruto", "Dellnge", "Dellcure", "Soniruto", "Hoorah", "Picklesmelda", "Hernifer", "Frediam", "Scottkin", "Leonathan", "Dellbert", "Kuiam", "Kunge", "Sange", "Dell", "Scartaro", "Kev", "Jack", "Nanifer", "Scottnge", "Jackgito", "Saiam", "Koba", "Sonison", "Bonefred", "Snufgold", "Benbone", "Konifer", "Pickle", "Bonemer", "Hengold", "Hoo", "Scottruto", "Fnordnge", "Scarbert", "Moonard", "Nasuke", "Seannard", "Himneth", "Jacksmelda", "Bumsmelda", "Boneson", "Benby", "Snufnard", "Prenge", "Kenbone", "Sa", "Homefice", "Seanson", "Bumby", "Kobert", "Bumjo", "Moogold", "Prerah", "Bumgold", "Benpy", "Moo", "Himbert", "Korick", "Snufnifer", "Bonenard", "Premer", "Elson", "Jogold", "Kevkin", "Kujo", "Snuffred", "Gibfred", "Scarneth", "Gibseph", "Picklerah", "Bumbert", "Saba", "Kevnifer", "Hoobert", "Jackgold", "Kevjo", "Oraruto", "Scottmer", "Albone", "Fredby", "Al", "Dellgito", "Say", "Hergold", "Dellkin", "Kevsuke", "Grogseph", "Grogneth", "Gibneth", "Gib", "Boneby", "Fnordcure", "Eggkin", "Bumkin", "Homenge", "Preneth", "Herfice", "Hoobone", "Keny", "Them", "Pre", "Jackba", "Themmin", "Nacure", "Leoiam", "Mookin", "Orabert", "Kenson", "Henkin", "Snufcure", "Gibnifer", "Nabert", "Himrah", "Homekin", "Themgito", "Pickley", "Ken", "Jonge", "Dackrah", "Thempor", "Fnordpor", "Gibson", "Seanpor", "Hoofred", "Dacknard", "Soniiam", "Naneth", "Orasmelda", "Henby", "Kenfred", "Dack", "Dellmer", "Sabert", "The Sonimin", "Henbone", "Himpy", "Kopy", "Gibjo", "Dackbone", "Soninge", "Dackrick", "Hennard", "Sonigold", "Jacktaro", "Eggnge", "Fredtaro", "Gibruto", "Bonegold", "Themiam", "Mooseph", "Elrah", "Henjo", "Boneneth", "Elpor", "Kosuke", "Jo", "Leoruto", "Dellseph", "Dackbert", "Alpy", "Jorick", "Elbert", "Kennard", "Hooneth", "Frednge", "Kurick", "Nanard", "Leoneth", "Hoonifer", "Dackpy", "Komin", "The Fnordmin", "Jofred", "Dellpor", "Dellgold", "Themfred", "Themkin", "Snufbone", "Scarson", "Sonirick", "Pretaro", "Aliam", "Bonerah", "Groggito", "Scottgito", "Scarnifer", "Grogbone", "Prebone", "Leoby", "Kevrick", "Themcure", "Alsuke", "Prefice", "Jacknge", "Orajo", "Gibrah", "Bennard", "Bonebert", "Moofred", "Picklepor", "Scottson", "Kencure", "Henseph", "Pickletaro", "Moopy", "Prey", "Hoomin", "Alrah", "Grogbert", "Kevnathan", "Boneruto", "Seanrick", "Kugold", "Hometaro", "Kuneth", "Bumruto", "Fnordgito", "The Dellnge", "The Sacure", "Bonejo", "Grogtaro", "Gibiam", "Eggson", "Saruto", "Scottneth", "Kevsmelda", "Picklerick", "Elba", "Prepy", "Homemin", "Hernard", "Bensuke", "Picklenathan", "Kevfice", "Boney", "Gibgold", "Himiam", "Kevbone", "Bonesuke", "Bumnge", "Bonenge", "Picklecure", "Dellfice", "Moobone", "Dellfred", "The Na", "Safred", "Bentaro", "Picklemin", "Henneth", "Homenathan", "Kuy", "Himnathan", "Fredbone", "Fred", "Dellsmelda", "Leobone", "Bumseph", "Fnord", "Leogold", "Alrick", "Sonisuke", "Hernathan", "Snufnge", "Dackby", "Grogby", "Sapor", "Kuruto", "Delliam", "Hoopor", "Seanmer", "Scottnard", "Prenard", "Alson", "Sarah", "Scottpor", "Bummin", "The Soni", "Fredsmelda", "Oraseph", "Elneth", "Gibnathan", "Dellrick", "Prenathan", "Fnordbone", "Snufiam", "Mooby", "Sataro", "Seaniam", "Himgold", "Kubone", "Dackjo", "Sason", "Picklenifer", "Homeiam", "Sonirah", "Nabone", "Orafred", "Eggiam", "Kogito", "Saneth", "Alneth", "Sonijo", "Picklesuke", "Frednathan", "Orarah", "Kobone", "Benfice", "Scarmin", "Benneth", "Himjo", "Snufmer", "Dackneth", "The Eltaro", "Prebert", "Kunifer", "Scarjo", "Grognard", "Napy", "Bengold", "Elnard", "Mooba", "Sonifred", "Joba", "Eltaro", "Snufneth", "Elsmelda", "Gibcure", "Grogfred", "Fnordsuke", "Scottiam", "Picklebert", "Grogba", "Himson", "Joby", "Jackmin", "Egg", "Eggnifer", "Dackseph", "Elruto", "Elnathan", "Grogruto", "Homeneth", "Moofice", "Sarick", "Kevcure", "Dellsuke", "Kenrick", "Hoonard", "Mooson", "Himnge", "Dackiam", "Grognathan", "Kuseph", "Bumnathan", "Kumer", "Hoomer", "Moogito", "Scarpor", "Bumiam", "Safice", "Jackby", "Elnifer", "Jonifer", "Orafice", "Sanathan", "Bummer", "Bumgito", "Hootaro", "Kenpor", "Keviam", "The Moojo", "Bensmelda", "Elmer", "Sonineth", "Seannge", "The Pre", "Bumrah", "Heny", "Scary", "Fredpy", "Bencure", "Bumrick", "Sagito", "Hoosuke", "Sanifer", "Homenifer", "Herfred", "Eliam", "Eggba", "Benfred", "Oragito", "Moopor", "Leokin", "Scarcure", "Scarrick", "Frednifer", "Snufson", "Eggmer", "Hooiam", "Hertaro", "Himmer", "Leorick", "Eggbert", "Henrick", "Scottpy", "Scottsmelda", "Grognifer", "Scottnathan", "Bonetaro", "Saby", "Soninard", "Kevfred", "Grognge", "Seanpy", "Dackruto", "Jackkin", "Grogmin", "Nakin", "Dellnathan", "Eggby", "Benmer", "Scotttaro", "Themfice", "Kusmelda", "Gibfice", "Orabone", "Prerick", "Henfice", "Thempy", "Bonecure", "Jackfice", "Kevrah", "Leoy", "Bumpor", "Benrick", "Themrick", "Kurah", "Bennifer", "Jackruto", "Alpor", "Snufjo", "Scottseph", "Dacknathan", "Seanba", "Hooby", "Jackrah", "Seantaro", "Themson", "Gibgito", "Hensmelda", "Bumy", "Dackmin", "Gibmer", "Naby", "Bonebone", "Benbert", "Alnifer", "Seanmin", "Moosuke", "Picklegito", "Picklebone", "Sonifice", "Homefred", "Sonibone", "Kenby", "Kevseph", "Prefred", "Kevson", "Dacknge", "Bumnard", "Themby", "Gibpy", "Homeby", "Eggpor", "Moorick", "Homerah", "Kevmer", "Eggneth", "Kenmer", "Najo", "Seanneth", "Oraby", "Kensuke", "Bumtaro", "The Alruto", "Soninathan", "Hermer", "Dackgold", "Jacknifer", "Himcure", "Benba", "The Leo", "Gibpor", "Eggfice", "Soninifer", "Sakin", "Komer", "Gibkin", "Fnordbert", "Kunard", "Dacky", "Elkin", "Themnge", "Konathan", "Fredfice", "Orarick", "Kevmin", "Jackpor", "Scarba", "Gibba", "Herby", "Elseph", "Groggold", "Herrah", "Herruto", "Picklefred", "Scarsuke", "Snufseph", "Thembone", "Fredmer", "Homeruto", "Seansmelda", "Hennge", "Kotaro", "Snufkin", "Joiam", "Grogy", "Alseph", "Themsuke", "Themnard", "Koruto", "Scottcure", "Fnordseph", "Fredrick", "Grogpy", "Benrah", "Fnordnathan", "The Jorah", "Kufred", "Henpor", "Picklekin", "Elmin", "Kensmelda", "Mooiam", "Picklefice", "Dellba", "Leoson", "Oranathan", "Dackcure", "Scarnge", "Soniseph", "Themtaro", "Gibrick", "Benruto", "The Ko", "Algold", "Kufice", "Preba", "Henbert", "Themsmelda", "Moonge", "Eggruto", "Scottgold", "Scottrah", "Kogold", "Mooy", "Nataro", "Jackmer", "Himby", "Nagito", "Himnard", "The Dellruto", "Kuson", "Leosmelda", "Herbert", "Seannathan", "Prenifer", "Benjo", "Koby", "Sabone", "Benmin", "Jogito", "Fnordson", "Giby", "Benseph", "Hermin", "Leopor", "Herson", "Snufpy", "Dacksmelda", "The Dackruto", "Naba", "Himrick", "Hensuke", "Hookin", "Albert", "Konge", "Hoonge", "Soniba", "Gibnard", "Kuby", "Snufruto", "Hergito", "Homepor", "Hennifer", "Presuke", "Bonegito", "Himsuke", "Eggnathan", "Prepor", "Kevpor", "Eggjo", "Eggrah", "Narah", "Homerick", "Nanathan", "Kevgold", "Themba", "Almer", "Herseph", "Hentaro", "Kevtaro", "Himy", "Kevnard", "Sonigito", "Bonepor", "Eggsmelda", "Bennathan", "Snufmin", "Dellnard", "Pregito", "Fredneth", "Fnordkin", "Scottsuke", "Fredba", "Himba", "Seanruto", "Oraba", "Grogiam", "The Snufrah", "Joruto", "Kevnge", "Scottnifer", "Themrah", "Heniam", "Picklemer", "Hoogito", "Himnifer", "Fnordsmelda", "Nason", "Leorah", "Kenjo", "Fnordmin", "Leobert", "Hooson", "Dellnifer", "Fnordiam", "Jonard", "Dellneth", "Namin", "Grogfice", "Pickleseph", "Oraneth", "Soniy", "Gibsmelda", "Scottmin", "Picklenge", "Grogjo", "Snufrah", "Nange", "Kennifer", "Eggcure", "Pregold", "The Fnordnifer", "Fredcure", "Fnordby", "Mooruto", "Homeson", "Gibbone", "Saseph", "Kunathan", "Kenruto", "Fredmin", "Beny", "Bonerick", "Alnathan", "Dacktaro", "Eggy", "Sonimin", "Homebone", "Kupy", "The Dellmin", "Scarnard", "Samer", "Henson", "Picklenard", "Snufpor", "Sasmelda", "Hoosmelda", "Josuke", "Pickleneth", "Fredrah", "Kosmelda", "Sonibert", "Kenbert", "Sacure", "Jacky", "Snufrick", "Kusuke", "Himbone", "Jotaro", "Frednard", "Gibby", "Dackfice", "Egggito", "Moonifer", "Scarsmelda", "Alcure", "Himpor", "Herpor", "Gibsuke", "Grogmer", "Fnordruto", "Fnordtaro", "Kubert", "Naseph", "Sonitaro", "Eggbone", "Herkin", "Leomer", "Alfred", "Elfice", "Scottfred", "Kenrah", "Kuba", "Kevy", "Himseph", "Kengito", "Konard", "Kenkin", "Hery", "Bonefice", "Pickleba", "Almin", "Bennge", "Henmin", "Kennge", "Hernge", "Grogcure", "Herjo", "Delly", "Herrick", "Prejo", "Kokin", "Hooseph", "Aly", "Themnifer", "Elpy", "Snufby", "Himfice", "The Jobone", "Themgold", "Elnge", "Sonismelda", "Dellruto", "Himkin", "The Kenkin", "Fnordnard", "Homecure", "Soniby", "Fnordmer", "Bonenifer", "Fnordnifer", "Fnordgold", "Fredseph", "Themseph", "Scarbone", "Eggfred", "Kenba", "The Homenathan", "Eggsuke", "Homegito", "Gibtaro", "Herpy", "Themy", "Oracure", "Seanseph", "Dellson", "Orapy", "Kenpy", "Eggmin", "Snufsmelda", "Oramer", "Jackneth", "Grograh", "Scariam", "The Alfred", "Dellpy", "Seancure", "Leoba", "Sajo", "Scarby", "Moomin", "Kenneth", "Hoofice", "Snuffice", "Alkin", "Mootaro", "Beniam", "Jojo", "Pickleruto", "The Kensuke", "Jackrick", "Jackiam", "Oray", "Dackmer", "Joson", "Koseph", "The Egg", "Scarfred", "Fredy", "Korah", "Moobert", "Jomin", "Dellby", "Gibbert", "Kevba", "Fnordy", "Leotaro", "Scarruto", "Hoocure", "Oraiam", "Hooba", "Joneth", "The Benba", "Eggseph", "Preseph", "Hoojo", "Henmer", "Ely", "Grogsuke", "Jacknard", "The Hen", "Hengito", "Leonge", "Himfred", "Alsmelda", "Homeba", "Jobert", "Kennathan", "Sonikin", "Sonipor", "Orasuke", "The Henneth", "The Ken", "Leocure", "Hennathan", "Kojo", "Hoorick", "Leonifer", "Preruto", "Nafice", "Kupor", "Scotty", "Scarnathan", "Dellrah", "Fredsuke", "Hercure", "Bumneth", "Delljo", "Nafred", "Bumpy", "Josmelda", "Herneth", "Bumbone", "Moomer", "Seanfred", "The Prebone", "Bonekin", "The Bumnifer", "Leonard", "Nagold", "Kenmin", "The Kenby", "Altaro", "Fredruto", "The Kubert", "Sonimer", "Kofred", "Grogkin", "Jackseph", "Kofice", "Jomer", "Precure", "Mooneth", "Scarrah", "Bumcure", "Dackba", "Eggrick", "Seanfice", "The Sonineth", "Fredfred", "Fnordfice", "Themneth", "The Sa", "The Kobone", "Presmelda", "Hersmelda", "Himtaro", "Scarfice", "Scarmer", "Sagold", "Snuftaro", "Jackpy", "The Her", "Koy", "Scarseph", "Bumson", "Sapy", "Seannifer", "The Orasuke", "Fnordneth", "The Snufiam", "Preiam", "Scottbone", "Snufnathan", "Egggold", "Scarkin", "Sonicure", "Moocure", "Eggpy", "Kucure", "Moonathan", "Seanrah", "Samin", "The Hooba", "The Gibnathan", "Heriam", "Koneth", "Kumin", "The Hoonifer", "Gibmin", "Dackson", "The Ben", "The Benseph", "The Dackjo", "Thembert", "Preson", "Bonesmelda", "Henruto", "The Orakin", "The Fredmer", "Leofred", "Aljo", "Seanbert", "Homenard", "Dacknifer", "Kengold", "Pickleiam", "Naruto", "Seansuke", "Jopor", "The Oraby", "Jackbert"};
    
    static int index = 0;
    static bool first = true;

    public static string getNextName() {
        if (first) {
            index = Random.Range(0, henNames.Length - 1);
            first = false;
        }

        

        string s = henNames[index];

        index++;
        if(index < 0 || index >= henNames.Length) {
            index = 0;
        }

        return s;
        

    }
    
}
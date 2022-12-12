﻿namespace Calorie_Counter
{
    public class AdventofCodeDay8
    {
        public static void TreetopTreeHouse()
        {
            string day8Input = "200120010031113332213034140102430141241124321111512323442304040044220141342121012210022220211111200\r\n111021120230012003124233312003010303204555454332453445353125225214221214442214301113012111020220220" +
    "\r\n010000112330232223210123331341111021455213441355415452453433542411022110033014112420103200010200112\r\n210220131023203033023421012411405531115123145115445215311422135252541100222231431331003220231121021" +
    "\r\n020112210133112114444340100410411231114131452544155151415233415312511222041221113442132231003203100\r\n121210122332301142321211440441113455552434332511455325315545354524142541534411112013143013120333022" +
    "\r\n002022223332143323320030004111431434153352153321414154453442552321332341355132444030442110103203212\r\n212130023213100232130230411132244242133251435525323326611211534441513532233340420321144212221332012" +
    "\r\n112201210213131241203033341411115513233426453426433653356253533133113511115222441140433214102332200\r\n212012000101044144022321521321444445566546646625625665232323663631331412343532242340023204432003233" +
    "\r\n101233132121222100241254211542133266356326564552445466322626353633223221135151311240430411433022011\r\n200132020222314334333551152431232424524623645555522366665322366466545513112135535223102441334310202" +
    "\r\n023113000020114221524122422222662645435544455234636242322656464245462233555511334411233402112203303\r\n323212301014434412315252233452332225554646452654545433445553336343544664455435323243510303023142200" +
    "\r\n310022200424121333144123222262332322343322244646667564465544426245466232342143412141451122001041322\r\n212301111322001335441132334525635254352425553354565445643472236236266635446421522132452121404230333" +
    "\r\n222212444300345211222512256444456624535343536756355746664436374344346652444335121144422222340114403\r\n133103420101433344253425324366444265345745457464444766674564476573243345254266312555221132304022243" +
    "\r\n104024111323421413115464433455553477333456354575666765646757774776752425462423244113225443242031103\r\n102001244212344453145353232652647556546465453563544776667356374453675332254663444121345213131024201" +
    "\r\n224444241243433331136646422564367344447534333336573546336576477746463642222264422255444411444213332\r\n111102440221143134255523244546456346745346547453543465664363545634575433436342252431313443241200434" +
    "\r\n134231321331555233423635635366465473563535535586445888474374535544636375425246452265522242444124430\r\n234112414314111344422243544643454775656784865866884848444877466476364476356322553554245224411411221" +
    "\r\n034400114351525345222546546744637535635657575787587675474664764764736443646462322222525151425423322\r\n200214241324215322354446653764777674587466544685754678446567884767437556756324542252661541311422130" +
    "\r\n343144113253113264625454456777333344687566876677476786864558645875776364454562645333232242321313142\r\n343024121143435322432236376444777668467756646886688564457885758774655565674476525265433235351133020" +
    "\r\n403402124545255442342535445764457654765745674556784877787445455686478773563733543423236235255444144\r\n103322531152132266562676355566367676848756788886766967585484486646776553753344443262466623351341241" +
    "\r\n310355244513624552353465735465555764667556575665597778969594858667646774744555337236256442514154340\r\n023311451112523462333545544537465688645559988688956997665697964748587858337347363225646321434554144" +
    "\r\n320135522136342345436443367666564847488558589757575579796688785767645678467555334323622425311134113\r\n302355525243323546577736555686874886486985688686888898966978978668487864787645754566534465541511251" +
    "\r\n334125312126266532347576536548547584696886997768569758698995755875465674754333433642553345425533431\r\n341111335132225635365534457665748575977867585959997886979957965558787465664637533766462255534332423" +
    "\r\n332515314534343636736373478687676678865555895657977886779567677978977887466835476754353523355412552\r\n223554423243256435734467677444784886576856669787898778968956989875566754875777467667635224535114135" +
    "\r\n155522522343322534364735656868875656687568869667769697877887796866975856457447636733764232364431215\r\n242345244424435673345476658556448689589759768689899966877768987857579874745884637474453634352133231" +
    "\r\n415255446645436567674735664645455855996887768879976678686967768687868985856885736776326622253351232\r\n345511155426334655353457846578475998667966669787979667866969678557875668566464436456435236255355314" +
    "\r\n142554534636264637437346664558867877978687978689679869967766679569789677485678377367342526223134543\r\n445152112563265336347774464854776998568899676687677797996796877777879786686845577654534235322155423" +
    "\r\n333311452256452445537757558677965658888896678979799998788899698785896978877575444547572432544335251\r\n153342523322435374455644657476596955598987666997999878876686677879688676464687476363732553363413554" +
    "\r\n144335145664565566437454557675966795686769969779977988878679878778787789465465637576634655354532332\r\n152415343652336664567566647557776598677998979889877998977867798897785759685544636646555455665423232" +
    "\r\n233452324356364643433768554555595977968766779897887998898666688775789556775758843355374525244243434\r\n415514136342636535455644448567857957878867697988999887897878896698589669784466744746433345345355353" +
    "\r\n232342145445335734443368474877857768999979889789879797978786868766697957448687837436437246435352325\r\n423142134652644455355368647749855698998886897798977997799867788779868756865564445675347463653623132" +
    "\r\n221215125542657466763755887857659858677696867997877899797779899996787779754784846775376254442211254\r\n154531463524644747547747455647685566769977767978799879788898879798999996758665537564563322242224125" +
    "\r\n114543323332546776763457675777969696978788779877889799879998997975759878686666834757774555334611241\r\n353441154256436766664748544445957885788777978878979877989798876799786999466647747557553324526153313" +
    "\r\n433233236244364537664567776764977668967888876787887977898978679686668778764647857553662664333221513\r\n112335142543334473565677774456986769698869989679787999966877889796668798648474667745633463364123315" +
    "\r\n113555236654542657737447854474695576987788777767987976776779677896568655666568777374452626625515123\r\n335535115334436455537766485588496998559679678997888767666867796988758985466776445675326242423551222" +
    "\r\n113534446446435634464566878474597579966586699697988866966997787776788976778774466655756463456235323\r\n432234422656545375357656547448457656589888789768979867898878979959955468888683644466555336562315155" +
    "\r\n313344415452422533675445775845665999956589788887986877769867786689888565577764433373633363624515141\r\n222432351346446453465663784584875977688789959977876966969658866777886544775874577535665532224311252" +
    "\r\n225114233145352533344653757488874695566977756698769768695668575699668757584555454357642544414312222\r\n033415322244643242337557674678486867575857998965787859688788778777887745544746656765646262354135222" +
    "\r\n244444135424622245536477356767676647596876888859989597677576756885858547856577434533266366252341111\r\n043422441154553466473376764757644888596669857975585975898957778585855575867574554436566563342243533" +
    "\r\n331142132342425642446677456357664865566895568659588999997598897847485545576757377726563624233332331\r\n023252542543632422666654576368776445864568889675685656595757555564576478356355573264462564525315531" +
    "\r\n401013153355343645357335364463874854866687865999886679877556446867474565563474773455256232432344241\r\n021145311524153334266573666344586785645787666877957988698886547444446737764473344255436645355133043" +
    "\r\n343022114235145422524664767447348848745548778464684486768568675765556575337775543626443412212441440\r\n111402455441135334663624565477563468586767564584754776865658486876757446535673333342623334312243002" +
    "\r\n300312451335434322222245676775746358685854756547745674447587647487533473336654232544332431554454412\r\n433111155454541556355524273356653577688858857767884847858548544877576457444762553325524214215402141" +
    "\r\n131233333423335563265232427676636343767667757678865557657665545337553674363435662333422331253432142\r\n424110224332255444554444426563344537343587775787775766858448446366677553432226234426335534235001312" +
    "\r\n333412002215124441543424366273747763767633456777658554454464446357566564765333524264253113145112300\r\n101110030515255434456252656567734365435643756543777575374763565634563366532624443621453215143234300" +
    "\r\n303322412424455315323623364345353365376676743654344676735433644466637676342646445331232331222232310\r\n323112211415542144152522545435246756534467755554567676637543357465766366552324534423444455001240332" +
    "\r\n104010010231221552145233456226456635564775656444567465773637433733444632663325561451234351230241312\r\n121411232340543435321316435636242655564355535365574763633547465475523553325562122152444444042300041" +
    "\r\n131012210332331125512334254246234345354543573744464635755354544666345534262435114123351541032131413\r\n320204021134412321515435566234224352423426577577364457356445435455454244243342521425351312003010221" +
    "\r\n323114214132034241313542544555435465334424654666346364554655422236635456436354122354410044244241323\r\n013302120424301452153353441245652435266525344656664634425626224355262362255351231351513443132401213" +
    "\r\n320030122021334215313244242334523262333453263233364243362363226452453421344311524253311414201210001\r\n232000301112410134252124412414346224626463252363536262245565624425334453135542241232142142113023001" +
    "\r\n023101113421202000305251552134255163452646652324334242436543224522235515444445314014323100240020120\r\n320223110031202012323335553432231212252653563665545464422324656333443431535442453303001103202231020" +
    "\r\n102033222010100142203435155413125314311166645446465322244546532441244154143433143443342400201012012\r\n103310002120123402241302221241151441435355114335344522434421453552354154135223134443030043002000021" +
    "\r\n112323110033212002113322411233332355223342424233213123445224135331545115152043042400020200022133330\r\n022111301200101044211214231433231311322554214331413543414521424255241531111410022413003020200231110" +
    "\r\n012022111212202121003233141343155411314255551134343533133453252153433344441013011221420230021203220\r\n221101122202110034040022441212441254112211113355531534335143125434435312222200311411322330203331100" +
    "\r\n210122210200133032213341213111433213432513121525124133544144433541201142230241123430213303001122221";

            string[] rows = day8Input.Split("\r\n");
            string[] columns = new string[rows[0].Length];

            for (int i = 0; i < rows[0].Length; i++)
            {
                for (int j = 0; j < rows.Length; j++)
                {
                    columns[i] += rows[j].Substring(i, 1);
                }
            }

            int visibleTrees = (2 * rows.Length + 2 * columns.Length - 4), scenicScore = 0;

            for (int i = 1; i < rows.Length - 1; i++)
            {
                for (int j = 1; j < rows[0].Length - 1; j++)
                {
                    bool[] visible = { true, true, true, true };
                    char a = rows[i][j];
                    int left = 0, right = 0, above = 0, below = 0;
                    string leftRow = rows[i].Substring(0, j);
                    string rightRow = rows[i].Substring(j + 1);
                    string aboveColumn = columns[j].Substring(0, i);
                    string belowColumn = columns[j].Substring(i + 1);
                    for (int k = leftRow.Length - 1; k >= 0; k--)
                    {
                        if (!visible[0] || leftRow == null)
                        {
                            break;
                        }
                        visible[0] = a > leftRow[k];
                        left++;
                    }
                    foreach (char c in rightRow)
                    {
                        if (!visible[1] || rightRow == null)
                        {
                            break;
                        }
                        visible[1] = a > c;
                        right++;
                    }
                    for (int k = aboveColumn.Length - 1; k >= 0; k--)
                    {
                        if (!visible[2] || aboveColumn == null)
                        {
                            break;
                        }
                        visible[2] = a > aboveColumn[k];
                        above++;
                    }
                    foreach (char c in belowColumn)
                    {
                        if (!visible[3] || belowColumn == null)
                        {
                            break;
                        }
                        visible[3] = a > c;
                        below++;
                    }
                    if (visible.Contains(true))
                        visibleTrees++;
                    if ((left * right * above * below) > scenicScore)
                        scenicScore = left * right * above * below;
                }
            }
            Console.WriteLine($"The amount of visible trees from the outside of the grid: {visibleTrees}.");
            Console.WriteLine($"Highest Scenic Score:{scenicScore}");
            Console.ReadKey();

        }
    }
}

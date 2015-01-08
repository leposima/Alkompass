using System;
using System.Collections.Generic;

namespace CSVfy
{
 public class Myymalat
{
public static Alko[] alkot = {
new Alko(24.934792,60.170814,"[Alko Helsinki keskusta Arkadia]")
,
new Alko(24.95006,60.164371,"[Alko Helsinki Kasarmitori]")
,
new Alko(24.930095,60.161259,"[Alko Helsinki Bulevardi]")
,
new Alko(24.937932,60.169013,"[Alko Helsinki keskusta Forum]")
,
new Alko(24.943421,60.159321,"[Alko Helsinki Ullanlinna]")
,
new Alko(24.955068,60.187262,"[Alko Helsinki Kallio]")
,
new Alko(24.91082,60.191034,"[Alko Helsinki Meilahti]")
,
new Alko(24.947375,60.221808,"[Alko Helsinki K�pyl�]")
,
new Alko(24.935651,60.197313,"[Alko Helsinki It�-Pasila]")
,
new Alko(24.849934,60.239155,"[Alko Helsinki Konala Ristikko]")
,
new Alko(24.91022,60.163317,"[Alko Helsinki Ruoholahti]")
,
new Alko(24.967176,60.203124,"[Alko Helsinki Arabianranta Arabia]")
,
new Alko(24.959544,60.174411,"[Alko Helsinki Kruununhaka]")
,
new Alko(24.876523,60.205564,"[Alko Helsinki Munkkivuori]")
,
new Alko(24.88168,60.160287,"[Alko Helsinki Lauttasaari]")
,
new Alko(24.948811,60.180342,"[Alko Helsinki Hakaniemi Ympyr�talo]")
,
new Alko(24.928815,60.236792,"[Alko Helsinki Pakila]")
,
new Alko(24.923898,60.17867,"[Alko Helsinki T��l�ntori]")
,
new Alko(24.86974,60.217522,"[Alko Helsinki Pit�j�nm�ki]")
,
new Alko(24.938604,60.17037,"[Alko Helsinki keskusta Sokos]")
,
new Alko(25.009999,60.227485,"[Alko Helsinki Viikki Prisma]")
,
new Alko(24.942498,60.168312,"[Alko Helsinki keskusta Stockmann]")
,
new Alko(25.01398,60.251175,"[Alko Helsinki Malmi Nova]")
,
new Alko(25.033626,60.194368,"[Alko Helsinki Herttoniemi Megahertsi]")
,
new Alko(24.888702,60.23694,"[Alko Helsinki Kannelm�ki Kaari]")
,
new Alko(25.084704,60.213093,"[Alko Helsinki It�keskus Itis Stockmann]")
,
new Alko(25.087828,60.213933,"[Alko Helsinki It�keskus Prisma]")
,
new Alko(25.083609,60.238283,"[Alko Helsinki Kontula]")
,
new Alko(25.144982,60.207303,"[Alko Helsinki Vuosaari Columbus]")
,
new Alko(25.085375,60.209894,"[Alko Helsinki It�keskus Citymarket]")
,
new Alko(24.739994,60.240856,"[Alko Espoo L�hderanta]")
,
new Alko(24.735635,60.167325,"[Alko Espoo Olari Prisma]")
,
new Alko(24.808582,60.176391,"[Alko Espoo Tapiola Ainoa]")
,
new Alko(24.809618,60.217952,"[Alko Espoo Lepp�vaara Sello]")
,
new Alko(24.658903,60.203856,"[Alko Espoo Espoon keskus Entresse]")
,
new Alko(24.76066,60.169771,"[Alko Espoo Niittykumpu Niittytori]")
,
new Alko(24.65783,60.14857,"[Alko Espoo Espoonlahti Lippulaiva]")
,
new Alko(24.738737,60.162314,"[Alko Espoo Matinkyl� Iso Omena]")
,
new Alko(24.447016,60.11846,"[Alko Kirkkonummi Munkinm�ki Prisma]")
,
new Alko(24.766302,60.20395,"[Alko Espoo Mankkaa]")
,
new Alko(25.032216,60.293733,"[Alko Vantaa Tikkurila]")
,
new Alko(24.851973,60.259856,"[Alko Vantaa Myyrm�ki Myyrmanni]")
,
new Alko(25.079448,60.349978,"[Alko Vantaa Korso]")
,
new Alko(24.965878,60.291027,"[Alko Vantaa Pakkala Jumbo]")
,
new Alko(24.729559,60.209916,"[Alko Kauniainen]")
,
new Alko(24.801821,60.272377,"[Alko Vantaa H�meenkyl�]")
,
new Alko(24.968046,60.318722,"[Alko Vantaa Helsinki-Vantaan lentoasema]")
,
new Alko(24.970769,60.274556,"[Alko Vantaa Tammisto Citymarket]")
,
new Alko(24.963051,60.292564,"[Alko Vantaa Pakkala Jumbo Stockmann]")
,
new Alko(25.020038,60.397794,"[Alko Tuusula Hyryl�]")
,
new Alko(22.967983,59.824536,"[Alko Hanko]")
,
new Alko(25.058258,60.324255,"[Alko Vantaa Koivukyl� Citymarket]")
,
new Alko(23.439252,59.978987,"[Alko Raasepori Tammisaari]")
,
new Alko(24.005258,60.043109,"[Alko Inkoo]")
,
new Alko(23.663103,60.07065,"[Alko Raasepori Karjaa]")
,
new Alko(24.027772,60.229023,"[Alko Lohja Ojamo Citymarket]")
,
new Alko(24.065486,60.249308,"[Alko Lohja keskusta Lohjant�hti]")
,
new Alko(24.232129,60.534283,"[Alko Karkkila]")
,
new Alko(24.330636,60.332434,"[Alko Vihti Nummela Citymarket]")
,
new Alko(24.821425,60.457117,"[Alko Nurmij�rvi Kirkonkyl�]")
,
new Alko(24.759805,60.377847,"[Alko Nurmij�rvi Klaukkala Citymarket]")
,
new Alko(25.103374,60.402186,"[Alko Kerava Prisma]")
,
new Alko(25.101949,60.477074,"[Alko J�rvenp�� Citymarket]")
,
new Alko(25.317703,60.63764,"[Alko M�nts�l�]")
,
new Alko(25.084828,60.469467,"[Alko J�rvenp�� Prisma]")
,
new Alko(24.86303,60.632648,"[Alko Hyvink�� Willa]")
,
new Alko(25.271547,60.377014,"[Alko Sipoo Nikkil�]")
,
new Alko(25.651994,60.387436,"[Alko Porvoo N�si]")
,
new Alko(25.685876,60.39948,"[Alko Porvoo Tarmola]")
,
new Alko(26.226186,60.458504,"[Alko Loviisa]")
,
new Alko(25.329402,60.297758,"[Alko Sipoo S�derkulla]")
,
new Alko(22.265998,60.449795,"[Alko Turku keskusta Kauppahalli]")
,
new Alko(22.326498,60.445722,"[Alko Turku It�harju]")
,
new Alko(22.192296,60.490139,"[Alko Raisio Mylly]")
,
new Alko(22.286141,60.443938,"[Alko Turku Kupittaa]")
,
new Alko(22.235484,60.457427,"[Alko Turku Manhattan]")
,
new Alko(22.267278,60.452502,"[Alko Turku keskusta Wiklund]")
,
new Alko(22.232602,60.47357,"[Alko Turku L�nsikeskus Citymarket]")
,
new Alko(22.262909,60.450881,"[Alko Turku keskusta Stockmann]")
,
new Alko(22.324808,60.429156,"[Alko Turku Skanssi]")
,
new Alko(22.36202,60.407876,"[Alko Kaarina]")
,
new Alko(22.458444,60.50343,"[Alko Lieto]")
,
new Alko(22.229346,60.417817,"[Alko Turku Hirvensalo]")
,
new Alko(22.286593,60.472653,"[Alko Turku Tampereentie]")
,
new Alko(22.170569,60.490045,"[Alko Raisio keskusta]")
,
new Alko(22.687921,60.457487,"[Alko Paimio]")
,
new Alko(22.513118,60.429243,"[Alko Kaarina Piikki�]")
,
new Alko(21.35508,60.54504,"[Alko Kustavi]")
,
new Alko(21.412841,60.799447,"[Alko Uusikaupunki]")
,
new Alko(21.69798,60.875964,"[Alko Laitila]")
,
new Alko(22.591327,60.647216,"[Alko Aura]")
,
new Alko(21.989049,60.684015,"[Alko Myn�m�ki]")
,
new Alko(22.030951,60.467433,"[Alko Naantali]")
,
new Alko(22.308055,60.309207,"[Alko Parainen keskusta]")
,
new Alko(21.90989,60.192831,"[Alko Parainen Nauvo]")
,
new Alko(23.122481,60.387296,"[Alko Salo keskusta]")
,
new Alko(23.082953,60.393524,"[Alko Salo Halikko]")
,
new Alko(23.509684,60.633563,"[Alko Somero]")
,
new Alko(23.113334,60.205337,"[Alko Salo Perni�]")
,
new Alko(22.735125,60.164133,"[Alko Kemi�nsaari Kemi�]")
,
new Alko(22.507252,60.01985,"[Alko Kemi�nsaari Dragsfj�rd Taalintehdas]")
,
new Alko(23.045726,60.855905,"[Alko Loimaa]")
,
new Alko(19.9334,60.129421,"[Alko Jomala Maxinge Center]")
,
new Alko(19.94233,60.098919,"[Alko Maarianhamina Sittkoff]")
,
new Alko(21.799701,61.48529,"[Alko Pori keskusta]")
,
new Alko(21.757081,61.477106,"[Alko Pori Etel�v�yl� Prisma]")
,
new Alko(21.840197,61.454815,"[Alko Pori It�keskus Prisma]")
,
new Alko(21.504834,61.859844,"[Alko Merikarvia]")
,
new Alko(21.876054,61.427744,"[Alko Ulvila]")
,
new Alko(21.865994,61.5958,"[Alko Pori Noormarkku]")
,
new Alko(22.004645,61.365595,"[Alko Nakkila]")
,
new Alko(22.388775,61.806785,"[Alko Kankaanp��]")
,
new Alko(22.146361,61.313896,"[Alko Harjavalta]")
,
new Alko(22.357448,61.045141,"[Alko S�kyl�]")
,
new Alko(21.72763,61.202553,"[Alko Eurajoki]")
,
new Alko(21.506763,61.132434,"[Alko Rauma keskusta]")
,
new Alko(22.14335,61.129924,"[Alko Eura]")
,
new Alko(22.348445,61.255059,"[Alko Kokem�ki]")
,
new Alko(22.6988,61.179013,"[Alko Huittinen]")
,
new Alko(21.538096,61.131881,"[Alko Rauma �yh�]")
,
new Alko(23.623444,63.217527,"[Alko Lappaj�rvi]")
,
new Alko(22.577784,62.730335,"[Alko Ilmajoki]")
,
new Alko(22.833935,62.791914,"[Alko Sein�joki keskusta Anttila]")
,
new Alko(24.086633,62.550163,"[Alko �ht�ri]")
,
new Alko(23.614204,62.587067,"[Alko Alavus keskusta]")
,
new Alko(23.055516,63.100064,"[Alko Kauhava keskusta]")
,
new Alko(22.395859,62.615235,"[Alko Kurikka]")
,
new Alko(23.804257,63.004916,"[Alko Alaj�rvi]")
,
new Alko(23.023058,62.974633,"[Alko Lapua]")
,
new Alko(22.752904,62.486851,"[Alko Jalasj�rvi]")
,
new Alko(21.379701,62.2739,"[Alko Kristiinankaupunki]")
,
new Alko(22.183477,62.43392,"[Alko Kauhajoki]")
,
new Alko(23.727049,62.602426,"[Alko Alavus Tuuri]")
,
new Alko(22.850262,63.239095,"[Alko Kauhava Alah�rm�]")
,
new Alko(22.540322,63.532266,"[Alko Uusikaarlepyy]")
,
new Alko(21.739226,62.487718,"[Alko Teuva]")
,
new Alko(22.715981,63.678039,"[Alko Pietarsaari]")
,
new Alko(22.879101,62.806293,"[Alko Sein�joki Nurmo Prisma]")
,
new Alko(22.807628,62.792524,"[Alko Sein�joki Jouppi Citymarket]")
,
new Alko(21.337672,62.476622,"[Alko N�rpi�]")
,
new Alko(21.616857,63.098225,"[Alko Vaasa keskusta Citymarket]")
,
new Alko(21.646878,63.101757,"[Alko Vaasa Asevelikyl� Prisma]")
,
new Alko(21.65189,63.108279,"[Alko Vaasa Kivihaka Citymarket]")
,
new Alko(22.007641,62.979786,"[Alko Laihia]")
,
new Alko(24.419328,61.006729,"[Alko H�meenlinna Tiiri�]")
,
new Alko(24.461443,60.992139,"[Alko H�meenlinna H�meensaari]")
,
new Alko(24.563418,61.171382,"[Alko H�meenlinna Hauho]")
,
new Alko(24.649609,60.922387,"[Alko Janakkala Turenki]")
,
new Alko(23.6372,60.81186,"[Alko Forssa Prismakeskus]")
,
new Alko(23.630285,60.808372,"[Alko Forssa Kutomo]")
,
new Alko(25.010456,61.077225,"[Alko H�meenlinna Lammi]")
,
new Alko(24.77845,60.732814,"[Alko Riihim�ki Atomikortteli]")
,
new Alko(24.442811,60.720527,"[Alko Loppi]")
,
new Alko(25.275816,60.870555,"[Alko K�rk�l� J�rvel�]")
,
new Alko(26.03052,61.202979,"[Alko Heinola keskusta]")
,
new Alko(25.026043,60.788515,"[Alko Hausj�rvi Oitti]")
,
new Alko(25.998414,61.192999,"[Alko Heinola Citymarket]")
,
new Alko(24.734842,60.721974,"[Alko Riihim�ki Merkos]")
,
new Alko(25.681952,61.502352,"[Alko Sysm�]")
,
new Alko(24.506237,61.006264,"[Alko H�meenlinna Id�np��]")
,
new Alko(26.020975,61.579146,"[Alko Hartola]")
,
new Alko(25.737246,60.981861,"[Alko Lahti Karisma]")
,
new Alko(25.634262,60.935637,"[Alko Lahti Renkom�ki]")
,
new Alko(25.665995,60.986219,"[Alko Lahti Syke]")
,
new Alko(25.659033,60.98264,"[Alko Lahti Sokos]")
,
new Alko(25.654014,60.958912,"[Alko Lahti Laune]")
,
new Alko(25.678272,61.006472,"[Alko Lahti Holma]")
,
new Alko(25.516161,60.989939,"[Alko Hollola Salpakangas]")
,
new Alko(25.962447,60.937211,"[Alko Nastola Rakokivi]")
,
new Alko(25.730748,60.805143,"[Alko Orimattila]")
,
new Alko(25.545711,61.173231,"[Alko Asikkala V��ksy]")
,
new Alko(25.265784,61.349178,"[Alko Padasjoki]")
,
new Alko(22.911459,61.340121,"[Alko Sastamala Vammala]")
,
new Alko(23.512283,61.478415,"[Alko Nokia]")
,
new Alko(23.780325,62.240508,"[Alko Virrat]")
,
new Alko(23.021288,62.010248,"[Alko Parkano]")
,
new Alko(23.070562,61.762242,"[Alko Ikaalinen]")
,
new Alko(23.8672,61.167988,"[Alko Akaa Toijala]")
,
new Alko(23.549621,61.080473,"[Alko Urjala]")
,
new Alko(24.029415,61.266482,"[Alko Valkeakoski]")
,
new Alko(24.622603,62.033163,"[Alko M�ntt�]")
,
new Alko(24.357521,61.678308,"[Alko Orivesi]")
,
new Alko(25.688297,62.516746,"[Alko ��nekoski Hirvaskangas]")
,
new Alko(25.778512,62.264535,"[Alko Jyv�skyl� Sepp�l� Citymarket]")
,
new Alko(23.756124,61.499225,"[Alko Tampere Anttila]")
,
new Alko(23.770676,61.498807,"[Alko Tampere Stockmann]")
,
new Alko(23.819818,61.492203,"[Alko Tampere Kaleva Prisma]")
,
new Alko(23.758166,61.497127,"[Alko Tampere Sokos]")
,
new Alko(23.778285,61.503191,"[Alko Tampere Tammela]")
,
new Alko(23.781915,61.468627,"[Alko Tampere Koivistonkyl� Prisma]")
,
new Alko(24.067794,61.462267,"[Alko Kangasala keskusta]")
,
new Alko(23.880841,61.494844,"[Alko Tampere Linnainmaa Prisma]")
,
new Alko(23.756892,61.312805,"[Alko Lemp��l� keskusta]")
,
new Alko(23.852381,61.450919,"[Alko Tampere Hervanta Duo]")
,
new Alko(23.669295,61.51469,"[Alko Tampere Lielahti Citymarket]")
,
new Alko(23.841853,61.478346,"[Alko Tampere Turtola Citymarket]")
,
new Alko(23.645459,61.46598,"[Alko Pirkkala keskusta]")
,
new Alko(23.594696,61.564332,"[Alko Yl�j�rvi]")
,
new Alko(23.196255,61.639021,"[Alko H�meenkyr�]")
,
new Alko(23.977163,61.476944,"[Alko Kangasala Prisma]")
,
new Alko(23.716786,61.469506,"[Alko Pirkkala Partola]")
,
new Alko(23.799195,61.360117,"[Alko Lemp��l� Ideapark]")
,
new Alko(25.673711,62.136472,"[Alko Muurame]")
,
new Alko(24.560426,63.042863,"[Alko Kyyj�rvi]")
,
new Alko(24.071969,61.98498,"[Alko Ruovesi]")
,
new Alko(24.708457,62.258003,"[Alko Keuruu]")
,
new Alko(25.257256,62.707346,"[Alko Saarij�rvi]")
,
new Alko(24.804008,62.879189,"[Alko Karstula]")
,
new Alko(25.862125,63.076549,"[Alko Viitasaari]")
,
new Alko(25.579702,63.369812,"[Alko Pihtipudas]")
,
new Alko(25.724241,62.601088,"[Alko ��nekoski keskusta]")
,
new Alko(25.715219,62.289037,"[Alko Jyv�skyl� Palokka Prisma]")
,
new Alko(25.748515,62.242713,"[Alko Jyv�skyl� keskusta Sokos]")
,
new Alko(25.778421,62.258701,"[Alko Jyv�skyl� Sepp�l� Prisma]")
,
new Alko(25.718685,62.216138,"[Alko Jyv�skyl� Keljo Keljon kauppakeskus]")
,
new Alko(25.953412,62.414266,"[Alko Laukaa]")
,
new Alko(25.877603,62.248309,"[Alko Jyv�skyl� Vaajakoski]")
,
new Alko(25.196518,61.866123,"[Alko J�ms�]")
,
new Alko(26.106857,61.744075,"[Alko Joutsa]")
,
new Alko(26.435999,62.389205,"[Alko Hankasalmi]")
,
new Alko(25.181791,61.56593,"[Alko Kuhmoinen]")
,
new Alko(29.76513,62.600975,"[Alko Joensuu keskusta Sokos]")
,
new Alko(29.774824,62.618003,"[Alko Joensuu K�pykangas Prisma]")
,
new Alko(29.706821,62.628581,"[Alko Joensuu Pilkko Citymarket]")
,
new Alko(29.385043,62.529043,"[Alko Liperi]")
,
new Alko(30.149654,62.798109,"[Alko Joensuu Eno]")
,
new Alko(29.014013,62.728121,"[Alko Outokumpu]")
,
new Alko(30.143477,62.096867,"[Alko Kitee]")
,
new Alko(30.934764,62.672287,"[Alko Ilomantsi]")
,
new Alko(29.105163,63.556411,"[Alko Nurmes]")
,
new Alko(30.032385,63.316395,"[Alko Lieksa]")
,
new Alko(28.949571,61.875174,"[Alko Savonlinna Nojanmaa Prisma]")
,
new Alko(29.253305,63.243903,"[Alko Juuka]")
,
new Alko(27.247587,61.510779,"[Alko Mikkeli Ristiina]")
,
new Alko(28.17756,61.523938,"[Alko Puumala]")
,
new Alko(27.273595,61.689634,"[Alko Mikkeli keskusta Stella]")
,
new Alko(26.642199,61.987915,"[Alko Kangasniemi]")
,
new Alko(26.879372,61.416734,"[Alko M�ntyharju]")
,
new Alko(27.855548,61.896569,"[Alko Juva]")
,
new Alko(28.868356,61.86842,"[Alko Savonlinna keskusta Citymarket]")
,
new Alko(28.630546,62.425744,"[Alko Hein�vesi]")
,
new Alko(28.300051,62.066787,"[Alko Rantasalmi]")
,
new Alko(29.280315,61.911941,"[Alko Savonlinna Kerim�ki]")
,
new Alko(26.434785,61.42561,"[Alko Pertunmaa Kuortti]")
,
new Alko(27.164375,62.303469,"[Alko Pieks�m�ki]")
,
new Alko(27.299714,61.686663,"[Alko Mikkeli Graani]")
,
new Alko(27.868417,62.315079,"[Alko Varkaus]")
,
new Alko(27.788592,62.491531,"[Alko Lepp�virta]")
,
new Alko(28.371237,61.787281,"[Alko Sulkava]")
,
new Alko(27.189721,63.55605,"[Alko Iisalmi]")
,
new Alko(27.399304,63.366821,"[Alko Lapinlahti]")
,
new Alko(26.756019,63.233559,"[Alko Pielavesi]")
,
new Alko(26.62015,63.650315,"[Alko Kiuruvesi]")
,
new Alko(27.657723,63.074275,"[Alko Siilinj�rvi]")
,
new Alko(28.090054,63.200804,"[Alko Kuopio Nilsi�]")
,
new Alko(27.642216,62.839781,"[Alko Kuopio Petonen]")
,
new Alko(27.676846,62.892187,"[Alko Kuopio keskusta Sokos]")
,
new Alko(27.610635,62.864407,"[Alko Kuopio Kolmisoppi Citymarket]")
,
new Alko(27.631822,62.888673,"[Alko Kuopio Savilahti Prisma]")
,
new Alko(27.676868,62.9324,"[Alko Kuopio P�iv�ranta Citymarket]")
,
new Alko(27.119036,62.625775,"[Alko Suonenjoki]")
,
new Alko(28.479923,62.974878,"[Alko Kaavi]")
,
new Alko(26.973215,62.894964,"[Alko Kuopio Karttula]")
,
new Alko(26.799732,60.929977,"[Alko Kouvola Valkeala]")
,
new Alko(26.625951,60.906708,"[Alko Kouvola Kuusankoski]")
,
new Alko(26.653954,60.877378,"[Alko Kouvola Tervaskangas]")
,
new Alko(26.838245,60.692303,"[Alko Kouvola Inkeroinen]")
,
new Alko(26.708441,60.868299,"[Alko Kouvola keskusta]")
,
new Alko(26.658382,60.871403,"[Alko Kouvola Korjala Prisma]")
,
new Alko(26.340823,60.888789,"[Alko Iitti Kausala]")
,
new Alko(27.194155,60.569083,"[Alko Hamina]")
,
new Alko(27.70975,60.585202,"[Alko Virolahti]")
,
new Alko(26.943838,60.467086,"[Alko Kotka Pasaati]")
,
new Alko(26.867186,60.501522,"[Alko Kotka Sutela Prisma]")
,
new Alko(26.916507,60.505699,"[Alko Kotka Jumalniemi Citymarket]")
,
new Alko(26.557596,60.489119,"[Alko Pyht��]")
,
new Alko(27.568984,60.922663,"[Alko Luum�ki Taavetti]")
,
new Alko(28.195178,61.057062,"[Alko Lappeenranta keskusta Iso Kristiina]")
,
new Alko(28.202433,61.044756,"[Alko Lappeenranta Citymarket]")
,
new Alko(28.178024,61.050894,"[Alko Lappeenranta Leiri Prisma]")
,
new Alko(28.501645,61.118144,"[Alko Lappeenranta Joutseno]")
,
new Alko(28.76279,61.188554,"[Alko Imatra Mansikkala]")
,
new Alko(28.835851,61.224899,"[Alko Imatra Vuoksenniska]")
,
new Alko(27.681354,61.197615,"[Alko Savitaipale]")
,
new Alko(29.49947,61.554134,"[Alko Parikkala]")
,
new Alko(23.917357,63.901444,"[Alko Kannus]")
,
new Alko(23.950219,64.260334,"[Alko Kalajoki]")
,
new Alko(23.122473,63.833051,"[Alko Kokkola Kosila Prisma]")
,
new Alko(24.556233,64.060569,"[Alko Ylivieska]")
,
new Alko(24.828768,64.268537,"[Alko Oulainen]")
,
new Alko(23.689246,63.548406,"[Alko Kaustinen]")
,
new Alko(25.318171,63.748838,"[Alko Haapaj�rvi]")
,
new Alko(25.865079,64.265554,"[Alko Pulkkila]")
,
new Alko(25.982018,63.682499,"[Alko Pyh�j�rvi]")
,
new Alko(24.967176,63.929164,"[Alko Nivala]")
,
new Alko(25.364216,64.137733,"[Alko Haapavesi]")
,
new Alko(23.142568,63.836051,"[Alko Kokkola keskusta K-Supermarket]")
,
new Alko(25.760726,63.97384,"[Alko K�rs�m�ki]")
,
new Alko(24.492469,64.680272,"[Alko Raahe]")
,
new Alko(25.454925,64.807193,"[Alko Liminka]")
,
new Alko(27.748742,64.22102,"[Alko Kajaani Prisma]")
,
new Alko(28.383809,64.130616,"[Alko Sotkamo]")
,
new Alko(29.525218,64.127205,"[Alko Kuhmo]")
,
new Alko(28.505947,64.674993,"[Alko Hyrynsalmi]")
,
new Alko(27.736667,64.223235,"[Alko Kajaani keskusta Citymarket]")
,
new Alko(27.835359,64.403758,"[Alko Paltamo]")
,
new Alko(27.665958,64.869467,"[Alko Puolanka]")
,
new Alko(28.9083,64.8873,"[Alko Suomussalmi]")
,
new Alko(25.534825,64.952565,"[Alko Oulu Kaakkuri]")
,
new Alko(25.457923,65.054959,"[Alko Oulu Linnanmaa]")
,
new Alko(25.468476,65.01214,"[Alko Oulu Stockmann]")
,
new Alko(25.487853,65.010463,"[Alko Oulu Raksila]")
,
new Alko(25.460972,64.994041,"[Alko Oulu Limingantulli]")
,
new Alko(25.472193,65.030982,"[Alko Oulu V�livainio]")
,
new Alko(25.538211,64.903284,"[Alko Kempele Zeppelin]")
,
new Alko(25.349004,65.176562,"[Alko Oulu Haukipudas]")
,
new Alko(25.990905,64.808204,"[Alko Muhos]")
,
new Alko(25.778904,65.12757,"[Alko Oulu Kiiminki]")
,
new Alko(25.400345,64.934119,"[Alko Oulu Oulunsalo]")
,
new Alko(25.377275,65.322115,"[Alko Ii]")
,
new Alko(26.843812,64.560545,"[Alko Vaala]")
,
new Alko(26.995651,65.360774,"[Alko Pudasj�rvi]")
,
new Alko(29.160433,65.955778,"[Alko Kuusamo keskusta]")
,
new Alko(28.243856,65.574952,"[Alko Taivalkoski]")
,
new Alko(29.138535,66.16753,"[Alko Kuusamo Ruka]")
,
new Alko(27.541203,68.659689,"[Alko Inari Ivalo]")
,
new Alko(27.408828,68.419503,"[Alko Inari Saariselk�]")
,
new Alko(26.585427,67.413967,"[Alko Sodankyl�]")
,
new Alko(25.726452,66.503095,"[Alko Rovaniemi keskusta]")
,
new Alko(25.7578,66.517509,"[Alko Rovaniemi Saarenkyl�]")
,
new Alko(25.691872,66.491446,"[Alko Rovaniemi Etel�keskus]")
,
new Alko(26.509411,65.932795,"[Alko Ranua]")
,
new Alko(28.157987,66.112341,"[Alko Posio]")
,
new Alko(24.564834,65.740213,"[Alko Kemi]")
,
new Alko(24.527461,65.792657,"[Alko Keminmaa]")
,
new Alko(24.143978,65.84385,"[Alko Tornio]")
,
new Alko(23.677091,66.326552,"[Alko Ylitornio]")
,
new Alko(23.964842,66.773552,"[Alko Pello]")
,
new Alko(24.907671,67.657167,"[Alko Kittil� keskusta]")
,
new Alko(23.683955,67.955545,"[Alko Muonio]")
,
new Alko(23.820361,67.335298,"[Alko Kolari keskusta]")
,
new Alko(24.806355,67.808927,"[Alko Kittil� Levi]")
,
new Alko(24.154617,67.605228,"[Alko Kolari Yll�s �k�slompolo]")
,
new Alko(27.428403,66.715955,"[Alko Kemij�rvi]")
,
new Alko(28.670251,66.832076,"[Alko Salla]")
,
new Alko(23.639437,68.384754,"[Alko Enonteki� Hetta]")
,
new Alko(27.86485,70.080733,"[Alko Utsjoki Nuorgam]")
};
}
  public   class Alko
  {
     public double Longitude;
   public  double Latitude;
   public   string Nimi = string.Empty;
     public Alko(double longitude, double latitude, string nimi)
       {
        Longitude = longitude;
        Latitude = latitude;
        Nimi = nimi;
      } 
  } 
}

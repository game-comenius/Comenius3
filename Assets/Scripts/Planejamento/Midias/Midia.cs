using UnityEngine;
[System.Serializable]
public class Midia
{
    public NomeDeMidia nomeMidia { get; private set; }

    public Sprite sprite;

    public string nome { get; private set; }
    public string descricao { get; private set; }
    public string descricaoLonga { get; private set; }

    public Agrupamento agrupamento;

    public static void AtualizarNomes()
    {

    }

    public static string AtualizarTextosLinguas(NomeDeMidia nomeMidia, int valor)
    {
        if (valor == 0) //descricao pequena
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.PORTUGUES:
                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "<style=\"title\">Lousa</style>\n\nA lousa é uma superfície reutilizável, geralmente riscada com giz branco, utilizada para exp" +
                                "osição do conteúdo do docente ou de forma colaborativa para docente e estudante.\n\n<b>Categoria:</b>\nMídia de exposição tradicional";
                        case NomeDeMidia.LivroDidatico:
                            return "<style=\"title\">Livro Didático</style>\n\nO livro didático é uma mídia de consulta comum do docente e estudante, de cunho ped" +
                            "agógico, composto de exercícios, textos e imagens do conteúdo estudado, que acompanham o currículo escolar.\n\n<b>Categoria:</b>\nMíd" +
                            "ia de consulta tradicional";
                        case NomeDeMidia.Notebook:
                            return " <style=\"title\">Notebook</style>\n\n Computador portátil, provido de monitor de vídeo, geralmente de cristal líquido, e ativado por bateria, com peso inferior a 6 kg e dimensões compatíveis para ser utilizado no colo ou sobre uma pequena superfície plana. Normalmente exige que a pessoa esteja sentada.";
                        case NomeDeMidia.Celular:
                            return "<style=\"title\">Celular</style>\n\n O smartphone é um celular com tecnologias que incluem programas executados num sistema operacional, equivalente aos computadores. Os smartphones possibilitam que qualquer pessoa possa desenvolver e utilizar aplicativos. Existem apps dos mais variados tipos e para os mais variados objetivos. São capazes de conectar redes de dados para acesso à internet, sincronizar dados como um computador, além da agenda de contatos.";
                        case NomeDeMidia.Tablet:
                            return " <style=\"title\">Tablet</style>\n\n Dispositivo eletrónico portátil, fino e retangular, com tela tátil, usado para visualização de vários tipos de arquivos digitais, comunicação móvel, entretenimento. Possui funcionalidades diversas, como acesso a internet, visualização de fotos e arquivos e até leitura de livros. O Tablet é um meio termo entre o smartphone e o notebook."; ;
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "<style=\"title\">Livros, Jornais e Revistas</style>\n\nLivros, jornais e revistas são publicações de cunho literário, informat" +
                            "ivo, jornalístico ou de entretenimento. Contém páginas impressas em papel com textos e imagens. Podem ser usados como material" +
                            " para leitura, consulta, ou base de recorte para atividades.\n\n<b>Categoria:</b>\nMídia popular tradicional";
                        case NomeDeMidia.CadernosECartazes:
                            return "<style=\"title\">Caderno e Cartazes</style>\n\nCaderno e cartazes são mídias utilizadas para produção e armazenamento de infor" +
                            "mações por uso da escrita ou das imagens. Auxiliam no exercício de autonomia, colaborando para que os estudantes aprendam a si" +
                            "stematizar o conhecimento adquirido, as dúvidas e as descobertas feitas.\n\n<b>Categoria:</b>\nMídia de produção tradicional";
                        case NomeDeMidia.Televisao:
                            return "<style=\"title\">Televisão</style>\n\nA televisão aberta é um meio de comunição de massa que exibe uma programação fixa. Um si" +
                            "stema eletrônico de transmissão e recepção de imagens e sons gerados ao vivo ou previamente gravadas, com programações artísti" +
                            "cas, culturais, educativas, informativas etc.\n\n<b>Categoria:</b>\nMídia popular audiovisual.";
                        case NomeDeMidia.AparelhoDeSom:
                            return "true";
                        case NomeDeMidia.RedesSociais:
                            return "<style=\"title\">Redes Sociais</style>\n\nRedes Sociais são estruturas dinâmicas e complexas formadas por pessoas com valores " +
                            "e/ou objetivos em comum, interligadas de forma horizontal e predominantemente descentralizada, que existem desde o início da s" +
                            "ociedade humana. As redes sociais online se articulam pela internet através das mídias sociais para comunicação, troca de mens" +
                            "agens e partilha de conteúdos entre indivíduos e grupos, ampliando as possibilidades de todo tipo de relacionamento entre eles" +
                            ".\n\n<b>Categoria:</b>\nMídia popular digital"; ;
                        case NomeDeMidia.Jogos:
                            return "<style=\"title\">Jogos</style>\n\nUm Jogo digital é uma atividade lúdica composta por mecânicas, estéticas e narrativas, suporta" +
                            "das por uma tecnologia, onde o jogador realiza uma série de ações e decisões, que estão limitadas por regras e pelo o contexto " +
                            "do game, recebendo feedback constante e buscando alcançar um meta.\n\nCategoria:\nMídia popular digital ";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "<style=\"title\">Editores de áudio e vídeo</style>\n\nEditores de áudio e vídeo são softwares que proporcionam a edição de con" +
                            "teúdos que contenham som e imagem, por meio de opções para cortar, copiar e colar trechos de áudio e video, bem como aplicar e" +
                            "feitos diversos.\n\n<b>Categoria:</b>\nMídia de produção digital.";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "<style=\"title\">Editor de Texto e Planilhas</style>\n\nUm editor de texto é um software que permite aos usuários criar, alter" +
                            "ar ou editar arquivos de texto simples. Planilha eletrônica é um programa de computador que utiliza tabelas para realização de" +
                            " cálculos ou apresentação de dados. Editores e planilhas permitem personalizar o conteúdo criado como definição de cores, font" +
                            "e, espaçamentos e muito mais.\n\n<b>Categoria:</b>\nMídia de produção audiovisual.";
                        case NomeDeMidia.Plataformas:
                            return "<style=\"title\">Plataformas</style>\n\nPlataformas virtuais de aprendizagem são softwares que agregam ferrramentas para a cri" +
                            "ação, tutoria, gestão e compartilhamento de atividades com o objetivo de auxiliar o usuário à desenvolver e distribuir conteúd" +
                            "os diversos para cursos online e disciplinas semipresenciais para estudantes em geral.\n\n<b>Categoria:</b>\nMídia de consulta digital";
                        case NomeDeMidia.Aplicativos:
                            return "<style=\"title\">Aplicativos</style>\n\nApp ou aplicativos são softwares cujo  objetivo é ajudar o usuário a realizar d" +
                            "eterminadas tarefas, relacionadas a trabalho ou entretenimento, adaptados para os dispositivos móveis que passaram " +
                            "a fazer parte da vida das pessoas. Geralmente se refere aos softwares presentes em celulares e dispositivos inteligentes, como" +
                            " smart TVs, para as mais diversas funções.\n\n<b>Categoria:</b>\nMídia de consulta digital";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "<style=\"title\">Projetor Multimídia</style>\n\nO projetor multimídia, ou datashow, é um aparelho óptico, mecânico, capaz de p" +
                            "rojetar em uma superfície lisa e clara, todo tipo de imagem, fixa e em movimento, acoplado a um computador. Bastante usado p" +
                            "ara aulas expositivas mas também para apresentação de trabalhos dos estudantes.\n\n<b>Categoria:</b>Categoria:\nMídia de exposição digital.";
                        case NomeDeMidia.VideoGamePortatil:
                            return "<style=\"title\">Video game Portátil</style>\n\n É um console de videogame com tela e controles embutidos e dimensões reduzidas para que possa ser facilmente transportado. Tem como objetivo executar jogos eletrônicos como num videogame, é a opção ideal para jogar em espaços externos, quando estiver em trânsito ou para quem quer jogar online ou localmente no modo multiplayer."; 
                    }

                    break;

                case Idiomas.INGLES:

                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "<style=\"title\">Blackboard</style>\n\nThe blackboard is a reusable surface, usually scratched with white chalk, used for exp" +
                                "presentation of content by the teacher or collaboratively for teacher and student.\n\n<b>Category:</b>\nTraditional exhibition media";
                        case NomeDeMidia.LivroDidatico:
                            return "<style=\"title\">Textbook</style>\n\nThe textbook is a means of common consultation for teachers and students, with a pedagogical nature" +
                            "agogical, composed of exercises, texts and images of the content studied, which accompany the school curriculum.\n\n<b>Category:</b>\nMedium" +
                            "traditional consultation ia";
                        case NomeDeMidia.Notebook:
                            return " <style=\"title\">Notebook</style>\n\n Portable computer, equipped with a video monitor, usually liquid crystal, and activated by battery, weighing less than 6 kg and dimensions compatible for use on the lap or on a small flat surface. Typically requires the person to be seated.";
                        case NomeDeMidia.Celular:
                            return "<style=\"title\">Cell Phone</style>\n\n A smartphone is a cell phone with technologies that include programs that run on an operating system, equivalent to computers. Smartphones enable anyone to develop and use applications. There are apps of the most varied types and for the most varied purposes. They are capable of connecting data networks to access the internet, synchronizing data like a computer, in addition to the contact book.";
                        case NomeDeMidia.Tablet:
                            return " <style=\"title\">Tablet</style>\n\nPortable electronic device, thin and rectangular, with touch screen, used for viewing various types of digital files, mobile communication, entertainment. It has diverse functionalities, such as accessing the internet, viewing photos and files and even reading books. The Tablet is a middle ground between the smartphone and the notebook.";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "<style=\"title\">Books, Newspapers and Magazines</style>\n\nBooks, newspapers and magazines are publications of a literary, informational nature" +
                            "active, journalistic or entertainment. Contains pages printed on paper with texts and images. Can be used as material" +
                            " for reading, consultation, or clipping base for activities.\n\n<b>Category:</b>\nTraditional popular media";
                        case NomeDeMidia.CadernosECartazes:
                            return "<style=\"title\">Notebook and Posters</style>\n\nNotebook and posters are media used to produce and store information" +
                            "mations through the use of writing or images. They help in the exercise of autonomy, helping students to learn themselves" +
                            "systematize the knowledge acquired, doubts and discoveries made.\n\n<b>Category:</b>\nTraditional production media";
                        case NomeDeMidia.Televisao:
                            return "<style=\"title\">Television</style>\n\nOpen television is a means of mass communication that displays fixed programming. One si" +
                            "electronic system for transmitting and receiving images and sounds generated live or previously recorded, with artistic programming" +
                            "cas, cultural, educational, informative, etc.\n\n<b>Category:</b>\nPopular audiovisual media.";
                        case NomeDeMidia.AparelhoDeSom:
                            return "";
                        case NomeDeMidia.RedesSociais:
                            return "<style=\"title\">Social Networks</style>\n\nSocial Networks are dynamic and complex structures formed by people with values ​​" +
                            "and/or common objectives, interconnected in a horizontal and predominantly decentralized way, which have existed since the beginning of s" +
                            "human society. Online social networks are articulated via the internet through social media for communication, exchange of messages" +
                            "actions and sharing of content between individuals and groups, expanding the possibilities of all types of relationships between them" +
                            ".\n\n<b>Category:</b>\nDigital popular media";
                        case NomeDeMidia.Jogos:
                            return "<style=\"title\">Games</style>\n\nA digital game is a playful activity composed of mechanics, aesthetics and narratives, supports" +
                            "given by a technology, where the player carries out a series of actions and decisions, which are limited by rules and the context " +
                            "of the game, receiving constant feedback and seeking to achieve a goal.\n\nCategory:\nDigital popular media ";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "<style=\"title\">Audio and video editors</style>\n\nAudio and video editors are software that provide video editing " +
                            "content that contains sound and image, through options to cut, copy and paste audio and video excerpts, as well as apply and" +
                            "miscellaneous feats.\n\n<b>Category:</b>\nDigital production media.";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "<style=\"title\">Text and Spreadsheet Editor</style>\n\nA text editor is software that allows users to create, change" +
                            "ar or edit simple text files. A spreadsheet is a computer program that uses tables to carry out" +
                            "calculations or data presentation. Editors and spreadsheets allow you to customize the created content such as defining colors, font" +
                            "and, spacing and much more.\n\n<b>Category:</b>\nAudiovisual production media.";
                        case NomeDeMidia.Plataformas:
                            return "<style=\"title\">Platforms</style>\n\nVirtual learning platforms are software that add tools for learning " +
                            "action, mentoring, management and sharing of activities with the aim of helping the user to develop and distribute content " +
                            "the various ones for online courses and blended subjects for students in general.\n\n<b>Category:</b>\nDigital consultation media";
                        case NomeDeMidia.Aplicativos:
                            return "<style=\"title\">Applications</style>\n\nApp or applications are software whose objective is to help the user perform " +
                            "specific tasks, related to work or entertainment, adapted for the mobile devices that have passed " +
                            "to be part of people's lives. It generally refers to software present on cell phones and smart devices, such as" +
                            " smart TVs, for the most diverse functions.\n\n<b>Category:</b>\nDigital consultation media";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "<style=\"title\">Multimedia Projector</style>\n\nThe multimedia projector, or datashow, is an optical, mechanical device, capable of p" +
                            "to project on a smooth and clear surface, all types of images, fixed and moving, coupled to a computer. Widely used for" +
                            "for expository classes but also for presenting student work.\n\n<b>Category:</b>Category:\nDigital exhibition media.";
                        case NomeDeMidia.VideoGamePortatil:
                            return "<style=\"title\">Portable Video Game</style>\n\n It is a video game console with a screen and built-in controls and reduced dimensions so that it can be easily transported. Its objective is to play electronic games like a video game, is the ideal option for playing outdoors, when on the go or for those who want to play online or locally in multiplayer mode.";
                    }
                    break;

                case Idiomas.ESPANHOL:
                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "<style=\"title\">Pizarra</style>\n\nLa pizarra es una superficie reutilizable, generalmente rayada con tiza blanca, que se utiliza para exp" +
                                "mostrar contenido por parte del profesor o de forma colaborativa entre profesor y alumno.\n\n<b>Categoría:</b>\nMedios de exhibición tradicionales";
                        case NomeDeMidia.LivroDidatico:
                            return "<style=\"title\">Libro de texto</style>\n\nEl libro de texto es un medio de consulta común para profesores y estudiantes, con carácter pedagógico" +
                            "agógico, compuesto por ejercicios, textos e imágenes del contenido estudiado, que acompañan el currículo escolar.\n\n<b>Categoría:</b>\nMedio" +
                            "consulta de consulta tradicional";
                        case NomeDeMidia.Notebook:
                            return " <style=\"title\">Notebook</style>\n\n Ordenador portátil, equipado con un monitor de vídeo, normalmente de cristal líquido, y activado por batería, con un peso inferior a 6 kg y dimensiones compatibles para su uso en el regazo o sobre una pequeña superficie plana. Generalmente requiere que la persona esté sentada.";
                        case NomeDeMidia.Celular:
                            return "<style=\"title\">Teléfono celular</style>\n\n Un teléfono inteligente es un teléfono celular con tecnologías que incluyen programas que se ejecutan en un sistema operativo, equivalente a las computadoras. Los teléfonos inteligentes permiten que cualquier persona desarrolle y utilice aplicaciones . Hay aplicaciones de los más variados tipos y para los más variados propósitos. Son capaces de conectar redes de datos para acceder a internet, sincronizando datos como una computadora, además de la libreta de contactos.";
                        case NomeDeMidia.Tablet:
                            return " <style=\"title\">Tableta</style>\n\nDispositivo electrónico portátil, delgado y rectangular, con pantalla táctil, utilizado para visualización de diversos tipos de archivos digitales, comunicación móvil, entretenimiento. Tiene diversas funcionalidades, tales como acceder a Internet, ver fotografías y archivos e incluso leer libros. La tableta es un término medio entre el teléfono inteligente y el portátil.";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "<style=\"title\">Libros, periódicos y revistas</style>\n\nLos libros, periódicos y revistas son publicaciones de carácter literario e informativo" +
                            "activo, periodístico o de entretenimiento. Contiene páginas impresas en papel con textos e imágenes. Puede usarse como material" +
                            "para lectura, consulta o base de recortes para actividades.\n\n<b>Categoría:</b>\nMedios populares tradicionales";
                        case NomeDeMidia.CadernosECartazes:
                            return "<style=\"title\">Cuaderno y carteles</style>\n\nEl cuaderno y los carteles son medios utilizados para producir y almacenar información" +
                            "formaciones mediante el uso de la escritura o imágenes. Ayudan en el ejercicio de la autonomía, ayudando a los estudiantes a aprender por sí mismos" +
                            "sistematizar los conocimientos adquiridos, las dudas y los descubrimientos realizados.\n\n<b>Categoría:</b>\nMedios de producción tradicionales";
                        case NomeDeMidia.Televisao:
                            return "<style=\"title\">Televisión</style>\n\nLa televisión abierta es un medio de comunicación masiva que muestra programación fija. Una si" +
                            "sistema electrónico de transmisión y recepción de imágenes y sonidos generados en vivo o previamente grabados, con programación artística" +
                            "cas, culturales, educativos, informativos, etc.\n\n<b>Categoría:</b>\nMedios audiovisuales populares.";
                        case NomeDeMidia.AparelhoDeSom:
                            return "";
                        case NomeDeMidia.RedesSociais:
                            return "<style=\"title\">Redes Sociales</style>\n\nLas Redes Sociales son estructuras dinámicas y complejas formadas por personas con valores " +
                            "y/o objetivos comunes, interconectados de forma horizontal y predominantemente descentralizada, que existen desde principios del s" +
                            "sociedad humana. Las redes sociales online se articulan vía internet a través de los medios sociales para la comunicación, el intercambio de mensajes" +
                            "acciones y compartición de contenidos entre individuos y grupos, ampliando las posibilidades de todo tipo de relaciones entre ellos" +
                            ".\n\n<b>Categoría:</b>\nMedios populares digitales";
                        case NomeDeMidia.Jogos:
                            return "<style=\"title\">Juegos</style>\n\nUn juego digital es una actividad lúdica compuesta de mecánicas, estéticas y narrativas, soportes" +
                            "dado por una tecnología, donde el jugador realiza una serie de acciones y decisiones, las cuales están limitadas por las reglas y el contexto" +
                            "del juego, recibiendo retroalimentación constante y buscando alcanzar un objetivo.\n\nCategoría:\nMedios populares digitales ";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "<style=\"title\">Editores de audio y vídeo</style>\n\nLos editores de audio y vídeo son software que proporcionan edición de vídeo" +
                            "contenido que contiene sonido e imagen, a través de opciones para cortar, copiar y pegar extractos de audio y video, así como aplicar y" +
                            "varias hazañas.\n\n<b>Categoría:</b>\nMedios de producción digital.";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "<style=\"title\">Editor de texto y hojas de cálculo</style>\n\nUn editor de texto es un software que permite a los usuarios crear y cambiar" +
                            "ar o editar archivos de texto simples. Una hoja de cálculo es un programa informático que utiliza tablas para realizar" +
                            "cálculos o presentación de datos. Los editores y hojas de cálculo le permiten personalizar el contenido creado, como definir colores, fuente" +
                            "y, espaciado y mucho más.\n\n<b>Categoría:</b>\nMedios de producción audiovisual.";
                        case NomeDeMidia.Plataformas:
                            return "<style=\"title\">Plataformas</style>\n\nLas plataformas de aprendizaje virtual son software que agregan herramientas para el aprendizaje" +
                            "acción, tutoría, gestión e intercambio de actividades con el objetivo de ayudar al usuario a desarrollar y distribuir contenidos" +
                            "los diversos para cursos en línea y materias semipresenciales para estudiantes en general.\n\n<b>Categoría:</b>\nMedios de consulta digitales";
                        case NomeDeMidia.Aplicativos:
                            return "<style=\"title\">Aplicaciones</style>\n\nLa aplicación o aplicaciones son software cuyo objetivo es ayudar al usuario a realizar d" +
                            "tareas específicas, relacionadas con el trabajo o el entretenimiento, adaptadas a los dispositivos móviles que han pasado" +
                            "ser parte de la vida de las personas. Generalmente se refiere al software presente en teléfonos celulares y dispositivos inteligentes, como" +
                            " Televisores inteligentes, para las más diversas funciones.\n\n<b>Categoría:</b>\nMedios de consulta digitales";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "<style=\"title\">Proyector multimedia</style>\n\nEl proyector multimedia, o datashow, es un dispositivo óptico y mecánico capaz de p" +
                            "para proyectar sobre una superficie lisa y clara, todo tipo de imágenes, fijas y en movimiento, acopladas a una computadora. Muy utilizado para" +
                            "para clases expositivas pero también para presentar trabajos de estudiantes.\n\n<b>Categoría:</b>Categoría:\nMedios de exhibición digitales.";
                        case NomeDeMidia.VideoGamePortatil:
                            return "<style=\"title\">Videojuego Portátil</style>\n\n Es una consola de videojuegos con pantalla y controles incorporados y de dimensiones reducidas para que pueda ser transportada fácilmente. Su objetivo es Jugar juegos electrónicos como un videojuego, es la opción ideal para jugar al aire libre, cuando estás en movimiento o para aquellos que quieren jugar en línea o localmente en modo multijugador.";
                    }
                    break;
                default:
                    return "true";
            }

        }
        else if( valor == 1) //descricao grande
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.PORTUGUES:
                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "A lousa é uma mídia de exposição que acompanha o ofício do docente há algumas décadas, podendo ser utilizado de diversas " +
                                 "formas, de acordo com a  proposta metodológica de cada docente. Também pode ser trabalhada como espaço de expressão dos e" +
                                 "studantes. A lousa no formato digital permite a conexão com a internet, abrindo possibilidade para novas maneiras de expo" +
                                 "sição, criação de conteúdos e apresentação de informações de uma variedade de fontes, ampliando a interação e a participa" +
                                 "ção dos estudantes na aula.";

                        case NomeDeMidia.LivroDidatico:
                            return "O livro didático impresso é fornecido pela escola para o estudante. Traz informações sobre todos os conteúdos do ano leti" +
                                 "vo, normalmente utilizado como leitura do material didático complementar para as disciplinas específicas, com a mediação " +
                                 "do docente. Possui conteúdos e recursos como imagens, gráficos e diversos gêneros textuais, podendo também incluir questõ" +
                                 "es transversais.";
                        case NomeDeMidia.Notebook:
                            return " <style=\"title\">Notebook</style>\n\n Computador portátil, provido de monitor de vídeo, geralmente de cristal líquido, e ativado por bateria, com peso inferior a 6 kg e dimensões compatíveis para ser utilizado no colo ou sobre uma pequena superfície plana. Normalmente exige que a pessoa esteja sentada.";
                        case NomeDeMidia.Celular:
                            return "<style=\"title\">Celular</style>\n\n O smartphone é um celular com tecnologias que incluem programas executados num sistema operacional, equivalente aos computadores. Os smartphones possibilitam que qualquer pessoa possa desenvolver e utilizar aplicativos. Existem apps dos mais variados tipos e para os mais variados objetivos. São capazes de conectar redes de dados para acesso à internet, sincronizar dados como um computador, além da agenda de contatos.";
                        case NomeDeMidia.Tablet:
                            return "";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "Livros, jornais e revistas são mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpret" +
                                 "ação de diversos temas de forma mais aprofundada. É possível refletir sobre o tratamento dos textos e imagens de acordo c" +
                                 "om cada gênero, ou as diferenças entre revistas, jornais e livros que são idealizadas e produzidas com objetivos e formas" +
                                 " diferentes nas diversas abordagens ideológicas e culturais ali evidentes, ou ainda discutir sobre a criticidade das info" +
                                 "rmações que são passadas, bem como os pontos de vista e a quais interesses essas mídias atendem.";
                        case NomeDeMidia.CadernosECartazes:
                            return "Caderno e cartazes geralmente são feitos pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou" +
                                 " em grupo para proporcionar a produção coletiva. Com os cartazes, os estudantes podem apresentar e socializar o que foi p" +
                                 "roduzido com o grupo a partir de pesquisa, produção textual, produção visual e gráfica, expressando de forma artística op" +
                                 "iniões, reflexões e conhecimentos. Nos cadernos os estudantes elaboram, sistematizam e armazenam os conteúdos aprendidos.";
                        case NomeDeMidia.Televisao:
                            return "A televisão é tanto um sistema de transmissão, como o dispositivo ou aparelho de visualização das imagens e sons, como a " +
                                 "programação televisiva e como a emissora que transmite os programas, tanto em rede aberta gratuita ou canais fechados e p" +
                                 "agos. Como ferramenta, pode ser utilizada na sala de aula para mostrar vídeos, filmes e documentários que contribuam com " +
                                 "os conteúdos trabalhados, possibilitando refletir como um veículo de informação e comunicação de massa pode atingir diver" +
                                 "sos lugares e pessoas ao mesmo tempo e as práticas culturais por ele geradas. Além disso, pode-se estudar a programação e" +
                                 " as emissoras, seus produtos, a arte, a cultura e a ideologia, refletindo de forma criítica o que ali é transmitido, tant" +
                                 "o os pontos de vistas e seus interesses como as diferentes informações ali veiculadas.";
                        case NomeDeMidia.AparelhoDeSom:
                            return "";
                        case NomeDeMidia.RedesSociais:
                            return "As redes sociais online têm o objetivo de conectar pessoas e compartilhar informações entre os que compactuam dos mesmos " +
                                 "valores e interesses. As escolas podem usá-las para contribuir para a mobilização de saberes e de aprendizagens colaborat" +
                                 "ivas, por meio de frequentes trocas, debates, de diferentes perspectivas, fortalecendo as relações interpessoais da turma" +
                                 " e aumentando a interação com os docentes, com os pais e com a sociedade em geral. Além disso, as redes sociais online po" +
                                 "dem ser usadas para grupos de estudo, conteúdos extras, chat para dúvidas, calendários de eventos escolares e formação pa" +
                                 "ra leitura e uso crítico. Com uma utilização contextualizada, mediada e expressivo-produtiva, os estudantes podem criar, " +
                                 "produzir e compartilhar conteúdos, subtituindo uma interação passiva e sendo mais protagonistas no desenvolvimento de sua" +
                                 " aprendizagem.";
                        case NomeDeMidia.Jogos:
                            return "Os jogos digitais são sistemas de simulações da realidade que substituída por situações lúdicas, permitindo aos jogadores" +
                                 " uma visão de distintos modelos de realidade. Estudos demostram que os jogos digitais podem desenvolver habilidades como " +
                                 "o pensamento crítico e o sistemático, a resolução de problemas, o desenvolvimento da ortografia, do vocabulário e da leit" +
                                 "ura, bem como aprendizagens específicas de domínio de diferentes áreas (como um novo idioma, por exemplo) além de uma gam" +
                                 "a de habilidades cognitivas, incluindo visualização espacial, atenção dividida e autorregulação emocional. Os jogos se co" +
                                 "nfiguram como um meio pedagógico versátil, através do qual as práticas sociais se entrelaçam e os conhecimentos individua" +
                                 "is se relacionam, na interação com a informação, com outros estudantes, ferramentas e materiais. A diversão assume fator " +
                                 "importante no processo, aliada ao relaxamento e motivação que os desafios trazem para executar as ações.";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "Os sotwares de edição de áudio e vídeo são ferramentas que instigam a pesquisa em sala de aula, pois, ao produzir com ess" +
                                 "as mídias podemos incentivar a reflexão de diferentes temas, a criatividade e o trabalho em equipe. Muitos destes softwar" +
                                 "es apresentam um conjunto de ferramentas versáteis, dinâmicas e de fácil aprendizado. Para fazer seus vídeos ou áudios, o" +
                                 "s estudantes precisam exercitar interação, interatividade e pensar em formas diferentes e dinâmicas de transmitir o que e" +
                                 "les querem dizer e de conquistar a atenção de seus colegas, dessa forma constroem conhecimento em colaboração, a partir d" +
                                 "este recurso tecnológico. Além disso, a produção audiovisual é tanto uma linguagem como uma habilidade importante para as" +
                                 " demandas do século XXI.";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "O funcionamento desses softwares é bem simples, ao mesmo tempo em que permitem que os estudantes sejam protagonistas da p" +
                                 "rópria aprendizagem. Nas páginas em branco é possível criar, formatar, editar, salvar documentos eletrônicos, misturando " +
                                 "elementos visuais e verbais. Por ser composto de recursos de escolha da fonte, inseção de imagens, criação de gráficos e " +
                                 "tabelas, estes editores de texto convidam a fomentar a escrita, a leitura e o desenvolvimento da criatividade, da aprendi" +
                                 "zagem colaborativa, das habilidades de escrita além de serem ferramentas de apoio à produção de pesquisa, tratamento e ap" +
                                 "resentação de dados de forma visual e complexa.";
                        case NomeDeMidia.Plataformas:
                            return "As plataformas de ambiente virtual de aprendizagem disponibilizam diversas ferramentas de comunicação, gestão e interaçã" +
                                 "o. Uma plataforma perpassa todo o processo de aprendizagem de um aluno, no caso de cursos ou disciplinas a distância, sej" +
                                 "a para o planejamento de atividades a distância, semi-presenciais ou para complementar aulas presenciais com conteúdos vi" +
                                 "rtuais. Além da troca de materiais de estudo, disponibilizam-se tarefas, ocorrem trocas  textuais ou audiovisuais, intera" +
                                 "ções por escrito nas diversas ferramentas (fórum, chat, mensagens, carregamento de arquivos). Algumas plataformas como o " +
                                 "Moodle, oferecem ferramentas de gamificação e jogos incluindo a possibilidade da aprendizagem lúdica.";
                        case NomeDeMidia.Aplicativos:
                            return "Existem inúmeros aplicativos relacionados a diferentes necessidades e domínios. Para a utilização deles na educação é nec" +
                                 "essário traçar o objetivo pedagógico, em seguida analisar as possibidades da ferramenta e desenhar uma estratégia. O trab" +
                                 "alho com aplicativos permite hibridez e personalização do ensino. Traz diversos benefícios como ajudar a organizar tarefa" +
                                 "s, aprender um idioma, criar conteúdos multimídia, facilitar a distribuição de atividades, dentro e fora da sala de aula." +
                                 " Além disso, aproxima o aluno da mecânica, dinâmica, estética e finalidade das ferramentas utilizadas em diversos segment" +
                                 "os da sociedade, ampliando seu letramento do mundo digital.";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "O projetor multimídia tem sido cada vez mais utilizado pelos docentes como recurso pedagógico. Acoplado ao computador, a" +
                                 " uma caixa de som e conectado na internet, o projetor permite inúmeras atividades interativas, como uma tela criativa tan" +
                                 "to para docentes como estudantes, pois permite trabalhar não apenas com imagens fixas *fotos, planilhas, slides) mas tamb" +
                                 "ém vídeos, filmes, jogos, animações e todo tipo de linguagem audiovisual multimídia. As vantagens são muitas, pois permit" +
                                 "e ir além das aulas expositivas incluindo atividades interativas, servindo como uma tela criativa tanto para docentes com" +
                                 "o estudantes em aula presencial.";
                        case NomeDeMidia.VideoGamePortatil:
                            return "";
                    }

                    break;

                case Idiomas.INGLES:

                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "<style=\"title\">Lousa</style>\n\nA lousa é uma superfície reutilizável, geralmente riscada com giz branco, utilizada para exp" +
                                "osição do conteúdo do docente ou de forma colaborativa para docente e estudante.\n\n<b>Categoria:</b>\nMídia de exposição tradicional";

                        case NomeDeMidia.LivroDidatico:
                            return "The printed textbook is provided by the school to the student. Brings information about all the content of the leti year\" +\r\n                                 \"vo, normally used as reading of complementary teaching material for specific subjects, with mediation \" +\r\n                                 \"from the teacher. It has content and resources such as images, graphics and various textual genres, and may also include questions\" +\r\n                                 \"are transversal.";
                        case NomeDeMidia.Notebook:
                            return "<style=\"title\">Notebook</style>\n\n Portable computer, equipped with a video monitor, generally liquid crystal, and activated by a battery, weighing less than 6 kg and dimensions compatible for use in lap or on a small flat surface. It usually requires the person to be seated.";
                        case NomeDeMidia.Celular:
                            return "<style=\"title\">Cell Phone</style>\n\n A smartphone is a cell phone with technologies that include programs that run on an operating system, equivalent to computers. Smartphones make it possible for anyone to develop and use applications. There are apps of the most varied types and for the most varied purposes. They are capable of connecting data networks to access the internet, synchronizing data like a computer, in addition to the contact book.";
                        case NomeDeMidia.Tablet:
                            return "";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "Books, newspapers and magazines are social media, which can be used to work on reading and interpreting" +
                                 "action of different themes in more depth. It is possible to reflect on the treatment of texts and images according to" +
                                 "with each genre, or the differences between magazines, newspapers and books that are idealized and produced with objectives and forms" +
                                 "different in the different ideological and cultural approaches evident there, or even discuss the criticality of information" +
                                 "rmations that are passed, as well as the points of view and whose interests these media serve.";
                        case NomeDeMidia.CadernosECartazes:
                            return "Notebooks and posters are generally made by the students themselves, used for individual educational activities or" +
                                 " in groups to provide collective production. With posters, students can present and socialize what was done " +
                                 "produced with the group based on research, textual production, visual and graphic production, expressing in an artistic way" +
                                 "inions, reflections and knowledge. In notebooks, students prepare, systematize and store the content learned.";
                        case NomeDeMidia.Televisao:
                            return "Television is both a transmission system and a device or apparatus for displaying images and sounds, such as " +
                                 "television programming and as the broadcaster that broadcasts the programs, either on a free open network or closed channels and p" +
                                 "agos. As a tool, it can be used in the classroom to show videos, films and documentaries that contribute to " +
                                 "the contents worked on, making it possible to reflect on how a vehicle of information and mass communication can achieve diversity" +
                                 "these are places and people at the same time and the cultural practices generated by them. Furthermore, one can study programming and" +
                                 "the broadcasters, their products, art, culture and ideology, critically reflecting what is transmitted there, so much" +
                                 "the points of view and their interests as well as the different information conveyed there.";
                        case NomeDeMidia.AparelhoDeSom:
                            return "";
                        case NomeDeMidia.RedesSociais:
                            return "Online social networks aim to connect people and share information among those who share them " +
                                 "values ​​and interests. Schools can use them to contribute to the mobilization of knowledge and collaborative learning" +
                                 "ives, through frequent exchanges, debates, from different perspectives, strengthening the interpersonal relationships of the class" +
                                 " and increasing interaction with teachers, parents and society in general. In addition, online social networks can" +
                                 "can be used for study groups, extra content, chat for questions, school event calendars and pa training" +
                                 "for critical reading and use. With contextualized, mediated and expressive-productive use, students can create, " +
                                 "produce and share content, replacing passive interaction and being more protagonists in the development of your" +
                                 " learning.";
                        case NomeDeMidia.Jogos:
                            return "Digital games are systems of simulating reality that are replaced by playful situations, allowing players to" +
                                 " a vision of different models of reality. Studies show that digital games can develop skills such as " +
                                 "critical and systematic thinking, problem solving, development of spelling, vocabulary and reading" +
                                 "ura, as well as domain-specific learning from different areas (like a new language, for example) in addition to a gam" +
                                 "cognitive skills, including spatial visualization, divided attention, and emotional self-regulation. Games connect" +
                                 "they appear as a versatile pedagogical means, through which social practices intertwine and individual knowledge" +
                                 "is relate, in interaction with information, with other students, tools and materials. Fun takes on a factor " +
                                 "important in the process, combined with the relaxation and motivation that challenges bring to carry out the actions.";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "Audio and video editing software are tools that encourage research in the classroom, because, when producing with this" +
                                 "Media can encourage reflection on different themes, creativity and teamwork. Many of these software" +
                                 "es present a set of versatile, dynamic and easy-to-learn tools. To make your videos or audios, the" +
                                 "students need to exercise interaction, interactivity and think of different and dynamic ways of transmitting what is" +
                                 "they want to say and gain the attention of their colleagues, in this way they build knowledge in collaboration, from" +
                                 "this technological resource. Furthermore, audiovisual production is both a language and an important skill for" +
                                 "demands of the 21st century.";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "The operation of these software is very simple, at the same time they allow students to be protagonists of the p" +
                                 "own learning. On the blank pages you can create, format, edit, save electronic documents, mixing " +
                                 "visual and verbal elements. As it consists of resources for choosing the font, inserting images, creating graphics and " +
                                 "tables, these text editors invite you to encourage writing, reading and the development of creativity, of learning" +
                                 "collaborative zation of writing skills in addition to being tools to support the production of research, treatment and ap" +
                                 "presentation of data in a visual and complex way";
                        case NomeDeMidia.Plataformas:
                            return "Virtual learning environment platforms provide various communication, management and interaction tools" +
                                 "o. A platform permeates a student's entire learning process, in the case of distance learning courses or subjects, whether" +
                                 "a for planning distance activities, semi-presential or to complement face-to-face classes with vi content" +
                                 "rtuals. In addition to the exchange of study materials, tasks are made available, textual or audiovisual exchanges occur, interaction" +
                                 "written instructions in the various tools (forum, chat, messages, uploading files). Some platforms such as " +
                                 "Moodle, offer gamification tools and games including the possibility of playful learning.";
                        case NomeDeMidia.Aplicativos:
                            return "There are countless applications related to different needs and domains. For their use in education it is necessary" +
                                 "It is essential to outline the pedagogical objective, then analyze the possibilities of the tool and design a strategy. The work" +
                                 "garlic with applications allows hybridity and personalization of teaching. It brings several benefits such as helping to organize tasks" +
                                 "s, learn a language, create multimedia content, facilitate the distribution of activities, inside and outside the classroom." +
                                 "In addition, it brings the student closer to the mechanics, dynamics, aesthetics and purpose of the tools used in different segments" +
                                 "those of society, expanding their literacy in the digital world.";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "The multimedia projector has been increasingly used by teachers as a teaching resource. Attached to the computer, the" +
                                 "a speaker and connected to the internet, the projector allows countless interactive activities, such as a creative tan screen" +
                                 "suitable for teachers and students, as it allows you to work not only with still images (photos, spreadsheets, slides) but also" +
                                 "There are videos, films, games, animations and all types of multimedia audiovisual language. The advantages are many, as it allows" +
                                 "and go beyond expository classes to include interactive activities, serving as a creative canvas for both teachers with" +
                                 "students in face-to-face classes.";
                        case NomeDeMidia.VideoGamePortatil:
                            return "true";
                    }
                    break;

                case Idiomas.ESPANHOL:
                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "<style=\"title\">Lousa</style>\n\nA lousa é uma superfície reutilizável, geralmente riscada com giz branco, utilizada para exp" +
                                "osição do conteúdo do docente ou de forma colaborativa para docente e estudante.\n\n<b>Categoria:</b>\nMídia de exposição tradicional";

                        case NomeDeMidia.LivroDidatico:
                            return "La escuela proporciona el libro de texto impreso al estudiante. Trae información de todo el contenido del año leti" +
                                 "vo, normalmente utilizado como lectura de material didáctico complementario para materias específicas, con mediación" +
                                 "del docente. Tiene contenidos y recursos como imágenes, gráficos y diversos géneros textuales, pudiendo incluir también preguntas" +
                                 "son transversales.";
                        case NomeDeMidia.Notebook:
                            return "<style=\"title\">Notebook</style>\n\n Computadora portátil, equipada con un monitor de video, generalmente de cristal líquido, y accionada por una batería, con un peso inferior a 6 kg y dimensiones compatibles para su uso en el regazo o sobre una pequeña superficie plana. Generalmente requiere que la persona esté sentada.";
                        case NomeDeMidia.Celular:
                            return "\"<style=\\\"title\\\">Teléfono celular</style>\\n\\n Un teléfono inteligente es un teléfono celular con tecnologías que incluyen programas que se ejecutan en un sistema operativo, equivalente a las computadoras. Los teléfonos inteligentes permiten que cualquier persona desarrolle y utilice aplicaciones Existen aplicaciones de los más variados tipos y para los más variados propósitos. Son capaces de conectar redes de datos para acceder a internet, sincronizando datos como una computadora, además de la agenda.";
                        case NomeDeMidia.Tablet:
                            return "";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "Los libros, periódicos y revistas son medios sociales, que pueden utilizarse para trabajar la lectura y la interpretación" +
                                 "Acción de diferentes temas en mayor profundidad. Es posible reflexionar sobre el tratamiento de textos e imágenes según" +
                                 "con cada género, o las diferencias entre revistas, periódicos y libros que se idealizan y producen con objetivos y formas" +
                                 "diferentes en los diferentes enfoques ideológicos y culturales que allí se evidencian, o incluso discutir la criticidad de la información" +
                                 "rmaciones que se pasan, así como los puntos de vista y a qué intereses sirven estos medios.";
                        case NomeDeMidia.CadernosECartazes:
                            return "Los cuadernos y carteles generalmente son elaborados por los propios estudiantes, utilizados para actividades educativas individuales o" +
                                 "en grupos para brindar producción colectiva. Con carteles, los estudiantes pueden presentar y socializar lo realizado" +
                                 "producido con el grupo a base de investigación, producción textual, producción visual y gráfica, expresando de manera artística" +
                                 "conceptos, reflexiones y conocimientos. En cuadernos, los estudiantes preparan, sistematizan y almacenan los contenidos aprendidos.";
                        case NomeDeMidia.Televisao:
                            return "La televisión es a la vez un sistema de transmisión y un dispositivo o aparato para mostrar imágenes y sonidos, como " +
                                 "programación de televisión y como emisora ​​​​que transmite los programas, ya sea en cadena abierta gratuita o canales cerrados y p" +
                                 "hace. Como herramienta, se puede utilizar en el aula para mostrar vídeos, películas y documentales que contribuyan a " +
                                 "los contenidos trabajados permiten reflexionar sobre cómo un vehículo de información y comunicación masiva puede lograr la diversidad" +
                                 "son lugares y personas al mismo tiempo y las prácticas culturales que ellos generan. Además se puede estudiar programación y" +
                                 "las emisoras, sus productos, arte, cultura e ideología, reflejan críticamente lo que allí se transmite, tanto" +
                                 "los puntos de vista y sus intereses, así como las diferentes informaciones allí transmitidas";
                        case NomeDeMidia.AparelhoDeSom:
                            return "";
                        case NomeDeMidia.RedesSociais:
                            return "Las redes sociales en línea tienen como objetivo conectar personas y compartir información entre quienes la comparten " +
                                 "valores e intereses. Las escuelas pueden utilizarlos para contribuir a la movilización del conocimiento y al aprendizaje colaborativo" +
                                 "ives, a través de frecuentes intercambios, debates, desde diferentes perspectivas, fortaleciendo las relaciones interpersonales de la clase" +
                                 "y aumentando la interacción con profesores, padres y sociedad en general. Además, las redes sociales online pueden" +
                                 "se puede utilizar para grupos de estudio, contenido adicional, chat para preguntas, calendarios de eventos escolares y capacitación para padres" +
                                 "para lectura y uso crítico. Con un uso contextualizado, mediado y expresivo-productivo, los estudiantes pueden crear" +
                                 "produce y comparte contenidos, sustituyendo la interacción pasiva y siendo más protagonistas en el desarrollo de tu" +
                                 " aprendiendo.";
                        case NomeDeMidia.Jogos:
                            return "Los juegos digitales son sistemas de simulación de la realidad que se reemplazan por situaciones lúdicas, lo que permite a los jugadores" +
                                 "una visión de diferentes modelos de la realidad. Los estudios demuestran que los juegos digitales pueden desarrollar habilidades como " +
                                 "pensamiento crítico y sistemático, resolución de problemas, desarrollo de la ortografía, vocabulario y lectura" +
                                 "ura, así como aprendizaje de dominios específicos de diferentes áreas (como un nuevo idioma, por ejemplo) además de un juego" +
                                 "Habilidades cognitivas, incluida la visualización espacial, la atención dividida y la autorregulación emocional. Los juegos conectan" +
                                 "se presentan como un medio pedagógico polivalente, a través del cual se entrelazan las prácticas sociales y los conocimientos individuales" +
                                 "Es relacionarse, en interacción con información, con otros estudiantes, herramientas y materiales. La diversión cobra un factor" +
                                 "importante en el proceso, combinado con la relajación y motivación que traen los desafíos para realizar las acciones.";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "Los software de edición de audio y video son herramientas que fomentan la investigación en el aula, porque al producir con este" +
                                 "Los medios pueden fomentar la reflexión sobre diferentes temas, la creatividad y el trabajo en equipo. Muchos de estos software" +
                                 "es presenta un conjunto de herramientas versátiles, dinámicas y fáciles de aprender. Para realizar tus videos o audios, el" +
                                 "los estudiantes necesitan ejercitar la interacción, la interactividad y pensar en formas diferentes y dinámicas de transmitir lo que es" +
                                 "quieren decir y llamar la atención de sus colegas, de esta manera construyen conocimiento en colaboración, desde" +
                                 "Este recurso tecnológico. Además, la producción audiovisual es a la vez un lenguaje y una habilidad importante para" +
                                 "Las exigencias del siglo XXI.";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "El funcionamiento de estos software es muy sencillo, al mismo tiempo permiten que los estudiantes sean protagonistas de la p" +
                                 "propio aprendizaje. En las páginas en blanco puedes crear, formatear, editar, guardar documentos electrónicos, mezclar " +
                                 "elementos visuales y verbales. Ya que consta de recursos para elegir la fuente, insertar imágenes, crear gráficos y " +
                                 "tablas, estos editores de texto te invitan a fomentar la escritura, la lectura y el desarrollo de la creatividad, del aprendizaje" +
                                 "colaboración de las habilidades de escritura además de ser herramientas de apoyo a la producción de investigación, tratamiento y ap" +
                                 "presentación de datos de forma visual y compleja.";
                        case NomeDeMidia.Plataformas:
                            return "Las plataformas de entornos virtuales de aprendizaje brindan diversas herramientas de comunicación, gestión e interacción" +
                                 "o. Una plataforma permea todo el proceso de aprendizaje del estudiante, tratándose de cursos o materias a distancia, ya sea" +
                                 "a para planificar actividades a distancia, semipresenciales o para complementar las clases presenciales con vi contenidos" +
                                 "rtuales. Además del intercambio de materiales de estudio, se ponen a disposición tareas, se producen intercambios textuales o audiovisuales, interacción" +
                                 "instrucciones escritas en las distintas herramientas (foro, chat, mensajes, carga de archivos). Algunas plataformas como " +
                                 "Moodle ofrece herramientas de gamificación y juegos que incluyen la posibilidad de aprendizaje lúdico.";
                        case NomeDeMidia.Aplicativos:
                            return "Existen innumerables aplicaciones relacionadas con diferentes necesidades y dominios. Para su uso en educación es necesario" +
                                 "Es fundamental trazar el objetivo pedagógico, luego analizar las posibilidades de la herramienta y diseñar una estrategia. El trabajo" +
                                 "El ajo con aplicaciones permite la hibridación y personalización de la enseñanza. Aporta varios beneficios como ayudar a organizar las tareas" +
                                 "s, aprender un idioma, crear contenidos multimedia, facilitar la distribución de actividades, dentro y fuera del aula" +
                                 "Además, acerca al estudiante a la mecánica, dinámica, estética y finalidad de las herramientas utilizadas en los diferentes segmentos" +
                                 "los de la sociedad, ampliando su alfabetización en el mundo digital.";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "El proyector multimedia ha sido cada vez más utilizado por los profesores como recurso didáctico. Adjunto a la computadora, el\" +\r\n                                 \"un altavoz y conectado a internet, el proyector permite innumerables actividades interactivas, como una pantalla bronceadora creativa\" +\r\n                                 \"adecuado para profesores y estudiantes, ya que permite trabajar no sólo con imágenes fijas (fotos, hojas de cálculo, diapositivas) sino también\" +\r\n                                 \"Hay vídeos, películas, juegos, animaciones y todo tipo de lenguaje audiovisual multimedia. Las ventajas son muchas, ya que permite\" +\r\n                                 \"e ir más allá de las clases expositivas para incluir actividades interactivas, sirviendo como un lienzo creativo para ambos profesores\" +\r\n                                 \"estudiantes en clases presenciales.";
                        case NomeDeMidia.VideoGamePortatil:
                            return "";
                    }
                    break;
                default:
                    return "true";
            }
        }

        else if (valor == 2)//descricao nome
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.PORTUGUES:
                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "Lousa";

                        case NomeDeMidia.LivroDidatico:
                            return "LivroDidatico";
                        case NomeDeMidia.Notebook:
                            return "Notebook";
                        case NomeDeMidia.Celular:
                            return "Celular";
                        case NomeDeMidia.Tablet:
                            return "Tablet";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "LivrosJornaisERevistas";
                        case NomeDeMidia.CadernosECartazes:
                            return "CadernosECartazes";
                        case NomeDeMidia.Televisao:
                            return "Televisao";
                        case NomeDeMidia.AparelhoDeSom:
                            return "AparelhoDeSom";
                        case NomeDeMidia.RedesSociais:
                            return "RedesSociais";
                        case NomeDeMidia.Jogos:
                            return "Jogos";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "EditoresDeAudioEVideo";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "EditoresDeTextoEPlanilhasEletronicas";
                        case NomeDeMidia.Plataformas:
                            return "Plataformas";
                        case NomeDeMidia.Aplicativos:
                            return "Aplicativos";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "ProjetorMultimidia";
                        case NomeDeMidia.VideoGamePortatil:
                            return "VideoGamePortatil";
                    }

                    break;

                case Idiomas.INGLES:

                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "blackboard";

                        case NomeDeMidia.LivroDidatico:
                            return "Textbook";
                        case NomeDeMidia.Notebook:
                            return "Notebook";
                        case NomeDeMidia.Celular:
                            return "Cell phone";
                        case NomeDeMidia.Tablet:
                            return "Tablet";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "Books Newspapers And Magazines";
                        case NomeDeMidia.CadernosECartazes:
                            return "Notebooks and posters";
                        case NomeDeMidia.Televisao:
                            return "Television";
                        case NomeDeMidia.AparelhoDeSom:
                            return "Sound Device";
                        case NomeDeMidia.RedesSociais:
                            return "Social media";
                        case NomeDeMidia.Jogos:
                            return "Games";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "Audio and Video Editors";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "Text Editors and Electronic Spreadsheets";
                        case NomeDeMidia.Plataformas:
                            return "Platforms";
                        case NomeDeMidia.Aplicativos:
                            return "Applications";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "Multimedia Projector";
                        case NomeDeMidia.VideoGamePortatil:
                            return "Portable Video Game";
                    }
                    break;

                case Idiomas.ESPANHOL:
                    switch (nomeMidia)
                    {
                        case NomeDeMidia.Lousa:
                            return "Pizarra";

                        case NomeDeMidia.LivroDidatico:
                            return "Libro de texto";
                        case NomeDeMidia.Notebook:
                            return "Computadora portátil";
                        case NomeDeMidia.Celular:
                            return "Teléfono móvil";
                        case NomeDeMidia.Tablet:
                            return "Tableta";
                        case NomeDeMidia.LivrosJornaisERevistas:
                            return "Libros Periódicos Y Revistas";
                        case NomeDeMidia.CadernosECartazes:
                            return "Cuadernos Y Posters";
                        case NomeDeMidia.Televisao:
                            return "Televisión";
                        case NomeDeMidia.AparelhoDeSom:
                            return "Dispositivo de sonido";
                        case NomeDeMidia.RedesSociais:
                            return "Redes sociales";
                        case NomeDeMidia.Jogos:
                            return "Juegos";
                        case NomeDeMidia.EditoresDeAudioEVideo:
                            return "Editores de audio y vídeo";
                        case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                            return "Editores de texto y hojas de cálculo electrónicas";
                        case NomeDeMidia.Plataformas:
                            return "Plataformas";
                        case NomeDeMidia.Aplicativos:
                            return "Aplicaciones";
                        case NomeDeMidia.ProjetorMultimidia:
                            return "Proyector multimedia";
                        case NomeDeMidia.VideoGamePortatil:
                            return "Videojuego portátil";
                    }
                    break;
                default:
                    return "true";
            }
        }

        else if(valor == 3)
        {
            switch (nomeMidia)
            {
                case NomeDeMidia.Lousa:
                    return "Lousa";
                case NomeDeMidia.LivroDidatico:
                    return "LivroDidatico";
                case NomeDeMidia.Notebook:
                    return "Notebook";
                case NomeDeMidia.Celular:
                    return "Celular";
                case NomeDeMidia.Tablet:
                    return "Tablet";
                case NomeDeMidia.LivrosJornaisERevistas:
                    return "LivrosJornaisERevistas";
                case NomeDeMidia.CadernosECartazes:
                    return "CadernosECartazes";
                case NomeDeMidia.Televisao:
                    return "Televisao";
                case NomeDeMidia.AparelhoDeSom:
                    return "AparelhoDeSom";
                case NomeDeMidia.RedesSociais:
                    return "RedesSociais";
                case NomeDeMidia.Jogos:
                    return "Jogos";
                case NomeDeMidia.EditoresDeAudioEVideo:
                    return "EditoresDeAudioEVideo";
                case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                    return "EditoresDeTextoEPlanilhasEletronicas";
                case NomeDeMidia.Plataformas:
                    return "Plataformas";
                case NomeDeMidia.Aplicativos:
                    return "Aplicativos";
                case NomeDeMidia.ProjetorMultimidia:
                    return "ProjetorMultimidia";
                case NomeDeMidia.VideoGamePortatil:
                    return "VideoGamePortatil";
            }
        }
        return "true";
    }
    public Midia(NomeDeMidia nomeMidia)
    {
        this.nomeMidia = nomeMidia;
        nome = AtualizarTextosLinguas(nomeMidia, 2);
        descricao = AtualizarTextosLinguas(nomeMidia, 0);
        descricaoLonga = AtualizarTextosLinguas(nomeMidia, 1);
       
    }
}

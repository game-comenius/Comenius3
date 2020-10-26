using UnityEngine;
using System.Collections.Generic;

// Fonte = https://docs.google.com/spreadsheets/d/107qEmnJbyoW8dPyvz0AiuGCE1Tqok4ybZdin8u_vKHQ/edit#gid=0
public class AfirmacaoSobreMidia : Afirmacao
{
    public NomeDeMidia NomeDaMidia;

    public static AfirmacaoSobreMidia[] ObterTodasAsAfirmacoes(NomeDeMidia midia)
    {
        var lista = new List<AfirmacaoSobreMidia>();
        switch (midia)
        {
            case NomeDeMidia.Lousa:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "É uma mídia de exposição que acompanha o ofício do professor há algumas décadas."),
                    new AfirmacaoSobreMidia(true, "Pode ser utilizada de acordo com a proposta metodológica de cada professor."),
                    new AfirmacaoSobreMidia(true, "Superfície reutilizável, geralmente riscada com giz branco ou canetão."),
                    new AfirmacaoSobreMidia(true, "Utilizada principalmente para exposição do conteúdo."),
                    new AfirmacaoSobreMidia(true, "Pode ser utilizada de forma colaborativa entre professor e estudante."),
                    new AfirmacaoSobreMidia(true, "É conhecida também pelos nomes: quadro-negro e quadro-branco."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "É uma mídia que dá a possibilidade de discutir sobre a criticidade das informações que são passadas, bem como os pontos de vistas e a quais interesses essa mídia atende."),
                    new AfirmacaoSobreMidia(false, "É uma mídia para o estudantes elaborar e sistematizar os conteúdos aprendidos, tendo então, uma fonte de estudo e pesquisa com suas póprias anotações."),
                    new AfirmacaoSobreMidia(false, "É possível refletir sobre esta mídia como um veículo de informação de massa, que pode atingir diversos lugares ao mesmo tempo."),
                    new AfirmacaoSobreMidia(false, "A lousa é uma ferramentas que instiga a pesquisa em sala de aula."),
                });
                break;
            case NomeDeMidia.LivroDidatico:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "É um impresso fornecido pela escola que traz informações sobre todos os conteúdos das disciplinas do ano letivo."),
                    new AfirmacaoSobreMidia(true, "Normalmente utilizado como leitura do material didático complementar para as disciplinas específicas."),
                    new AfirmacaoSobreMidia(true, "Para sua maior efetividade necessita da mediação do professor."),
                    new AfirmacaoSobreMidia(true, "Essa mídia possui conteúdos e recursos como imagens, gráficos e diversos gêneros textuais, bem como questões transversais são abordadas neles."),
                    new AfirmacaoSobreMidia(true, "É uma mídia de consulta muito comum tanto de professores quanto alunos."),
                    new AfirmacaoSobreMidia(true, "É uma mídia composta de exercícios, textos e imagens do conteúdo estudado em sala que acompanha o currículo escolar."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Mídia composta de recursos que possibilitam escolher a fonte, inserir imagens, gráficos e tabelas, sendo um convite para fomentar a escrita, a leitura e o desenvolvimento da criatividade e aprendizagem colaborativa."),
                    new AfirmacaoSobreMidia(false, "O livro didático tem como característica pedagógica a sua personalização de conteúdos."),
                    new AfirmacaoSobreMidia(false, "Geralmente usadas pelos próprio professor, utilizados para atividades pedagógicas em grandes grupos para proporcionar a produção coletiva."),
                    new AfirmacaoSobreMidia(false, "Com o advento da internet essa mídia se tornaram obsoletas e não têm mais espaço naos processos de ensino e aprendizagem em sala de aula."),
                });
                break;
            case NomeDeMidia.LivrosJornaisERevistas:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "São publicações de cunho literário, informativo, jornalístico ou de entretenimento, geralmente voltada para o público em geral."),
                    new AfirmacaoSobreMidia(true, "Contém páginas impressas com textos e imagens. Podem ser usados como material para leitura,consulta, ou base de recorte para atividades."),
                    new AfirmacaoSobreMidia(true, "São mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpretação de diversos temas de forma mais aprofundada."),
                    new AfirmacaoSobreMidia(true, "Pode ser utilizado para refletir sobre o tratamento dos textos e imagens de acordo com cada gênero."),
                    new AfirmacaoSobreMidia(true, "Discutir sobre a criticidade das informações que são passadas, bem como os pontos de vistas e a quais interesses essas mídias atendem e as diversas abordagens ideológicas e culturais ali evidentes."),
                    new AfirmacaoSobreMidia(true, "São mídias impressas são de uso popular e contém diversos gêneros literários, destinadas a diferentes públicos."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Por serem mídias desenvolvidas por especialistas, cabe o professor apenas garantir o acesso a essas ferramentas deixando o aluno interpretá-las por si só sem a mediação do docente."),
                    new AfirmacaoSobreMidia(false, "Por ser uma mídia que já apresenta o conteúdo fechado fica inviável a mediação do professor com seu alunos acerca do tema."),
                    new AfirmacaoSobreMidia(false, "Com o advento da internet essas mídias se tornaram obsoletas e não têm mais espaço nas rotinas pedagógicas em sala de aula."),
                    new AfirmacaoSobreMidia(false, "Essas mídias aprensetam um forte viés ideológico, sendo desaconselhado trabalhar com crianças e jovens para que não sejam doutrinados por essas mídias de massa."),
                });
                break;
            case NomeDeMidia.CadernosECartazes:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "São mídias utilizadas para produção e armazenamento de informações por uso da escrita ou imagens, geralmente utilizadas pelos alunos."),
                    new AfirmacaoSobreMidia(true, "Geralmente usadas pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou em grupo para proporcionar a produção coletiva."),
                    new AfirmacaoSobreMidia(true, "Com uma dessas mídias os alunos podem apresentar e socializar o que foi produzido com o grupo escolar, produzir textos que permitem a pesquisa, produção textual, produção artística e expressar opiniões."),
                    new AfirmacaoSobreMidia(true, "Com uma dessas mídias os estudantes elaboram e sistematizam os conteúdos aprendidos, tendo então, uma fonte de estudo e pesquisa com suas póprias anotações."),
                    new AfirmacaoSobreMidia(true, "Uma de suas mídias pode ser considerada mais de uso individual e a outra mais de uso coletivo."),
                    new AfirmacaoSobreMidia(true, "São mídias de produção com flexibilidade para uso de textos e imagens."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "É uma mídia composta de exercícios, textos e imagens do conteúdo estudado em sala que acompanha o currículo escolar."),
                    new AfirmacaoSobreMidia(false, "São mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpretação de diversos temas de forma mais aprofundada."),
                    new AfirmacaoSobreMidia(false, "Mídia composta de recursos que possibilitam escolher a fonte, inserir imagens, gráficos e tabelas, sendo um convite para fomentar a escrita, a leitura e o desenvolvimento da criatividade e aprendizagem colaborativa."),
                    new AfirmacaoSobreMidia(false, "São mídias que focam no trabalho colaborativo no qual os esforços são dedicados sem ressentimento ou temor."),
                });
                break;
            case NomeDeMidia.Televisao:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "É uma mídia que reproduz imagens e sons transmitidos por antena ou por meio de um VHS."),
                    new AfirmacaoSobreMidia(true, "Pode ser utilizada na sala de aula para mostrar vídeos, filmes e documentários para contribuir com os conteúdos trabalhados."),
                    new AfirmacaoSobreMidia(true, "É possível refletir sobre esta mídia como um veículo de informação de massa, que pode atingir diversos lugares ao mesmo tempo."),
                    new AfirmacaoSobreMidia(true, "É uma mídia que dá a possibilidade de discutir sobre a criticidade das informações que são passadas, bem como os pontos de vistas e a quais interesses essa mídia atende."),
                    new AfirmacaoSobreMidia(true, "Com o auxílio de equipamentos de gravação ou contato com emissoras é possível a criação de vídeos feitos pela turma sobre determinados assuntos, seja sobre o cotidiano escolar ou disciplinas específicas."),
                    new AfirmacaoSobreMidia(true, "É uma mídia de recepção/reprodução de imagens e sons de programas televisivos jornalísticos, esportivos, educacionais e ficcionais, gravados ou ao vivo."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Por ser uma mídia que já apresenta o conteúdo fechado fica inviável a mediação do professor com seu alunos acerca do tema."),
                    new AfirmacaoSobreMidia(false, "Seu conteúdo é desenvolvido por especialistas, sendo assim, cabe o professor apenas garantir o acesso a essa mídia deixando o aluno interpretá-las por si só sem a mediação do docente."),
                    new AfirmacaoSobreMidia(false, "Geralmente usadas pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou em grupo para proporcionar a produção coletiva."),
                    new AfirmacaoSobreMidia(false, "Usada somente em situações de lazer, essa mídia pouco tem a oferecer como reprodutora de conteúdos pedagógicos."),
                });
                break;
            case NomeDeMidia.AparelhoDeSom:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "Mídia que reproduz o som captado no gravador de áudio, CDs e diferentes formatos."),
                    new AfirmacaoSobreMidia(true, "Seu uso diretamente ligado a ouvir, possibilitando a reprodução da atividade realizada por ele, seja para estudo, entretenimento ou informação."),
                    new AfirmacaoSobreMidia(true, "Pode ser utilizado para estudar conteúdos diversos, as formas, e as linguagens da gravação."),
                    new AfirmacaoSobreMidia(true, "Pode ser utilizada para reproduzir diferentes gêneros musicais ou programas literários sonoros, como audiolivros ou podcasts."),
                    new AfirmacaoSobreMidia(true, "Pode ser usada como base sonora para complementar qualquer atividade, como ilustração, informação ou acompanhamento."),
                    new AfirmacaoSobreMidia(true, "É uma mídia de uso em massa, para exposição de som, cultura, e dados."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Uma mídia muito limita e ultrapassada já que somente reproduz áudio não trazendo nenhum conteúdo pedagógico, apenas músicas."),
                    new AfirmacaoSobreMidia(false, "Geralmente usadas pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou em grupo para proporcionar a produção coletiva."),
                    new AfirmacaoSobreMidia(false, "Usada somente em situações de lazer, essa mídia pouco tem a oferecer como reprodutora de conteúdos pedagógicos."),
                    new AfirmacaoSobreMidia(false, "Por ser uma mídia que já apresenta o conteúdo fechado fica inviável a mediação do professor com seu alunos acerca do tema."),
                });
                break;
            case NomeDeMidia.RedesSociais:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "As redes sociais tem o objetivo de conectar pessoas e compartilhar informações entre elas, reunindo usuários que compactuam dos mesmos valores e interesses."),
                    new AfirmacaoSobreMidia(true, "As escolas com propostas intencionais podem usá-la para contribuir para a mobilização de saberes e de aprendizagens colaborativas."),
                    new AfirmacaoSobreMidia(true, "As redes sociais podem ser usadas para grupos de estudo, conteúdos extras, chat para dúvidas, calendários de eventos escolares e formação para leitura e uso crítico."),
                    new AfirmacaoSobreMidia(true, "Uma das fundamentais características na definição das redes é a sua abertura, possibilitando relacionamentos horizontais e não hierárquicos entre os participantes."),
                    new AfirmacaoSobreMidia(true, "São estruturas digitais (sites e aplicativos) formada por pessoas ou empresas com interesses comuns, que permite o compartilhamento de informações, criação de grupos e diálogos entre seus usuários."),
                    new AfirmacaoSobreMidia(true, "Redes Sociais são mídias digitais criadas prioritariamente para o entretenimento."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Uma das fundamentais características na definição das redes é a sua rigidez, exigindo relacionamentos verticais e hierárquicos entre os participantes."),
                    new AfirmacaoSobreMidia(false, "Redes Sociais são mídias digitais criadas prioritariamente para a educação."),
                    new AfirmacaoSobreMidia(false, "As redes sociais são sistemas de simulações nos quais as situações reais são substituídas por situações lúdicas, permitindo aos usuários uma visão de distintos modelos de realidade."),
                    new AfirmacaoSobreMidia(false, "As redes sociais são utilizadas principalmente para exposição do conteúdo."),
                    new AfirmacaoSobreMidia(false, "São mídias digitais de uso popular que contém diversos gêneros literários, destinadas a diferentes públicos que não interagem entre si."),
                    new AfirmacaoSobreMidia(false, "É uma mídia digital fornecida pela escola que traz informações sobre todos os conteúdos das disciplinas do ano letivo."),
                });
                break;
            case NomeDeMidia.Jogos:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "Os jogos digitais são sistemas de simulações nos quais as situações reais são substituídas por situações lúdicas, permitindo aos jogadores uma visão de distintos modelos de realidade."),
                    new AfirmacaoSobreMidia(true, "O lúdico chega às aulas para torna-las mais interessantes e agradáveis, uma estratégia que busca estimular o raciocínio, concentração, levando o aluno a enfrentar situações conflitantes relacionadas com seu cotidiano."),
                    new AfirmacaoSobreMidia(true, "Os jogos se configuram como um meio pedagógico versátil, através do qual as práticas sociais se entrelaçam e os conhecimentos individuais se relacionam, na interação com a informação, com outros alunos, ferramentas e materiais."),
                    new AfirmacaoSobreMidia(true, "Com os jogos sendo utilizados para a educação, a diversão assume fator importante no processo, aliada ao relaxamento e motivação para executar as ações."),
                    new AfirmacaoSobreMidia(true, "É um trabalho colaborativo no qual os esforços são dedicados sem ressentimento ou temor."),
                    new AfirmacaoSobreMidia(true, "Os Jogos Digitais são desenhados para serem jogados num computador, numa console ou outro dispositivo tecnológico, contendo gêneros, propostas e mecânicas variadas."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Os jogos digitais são sistemas de simulações nos quais as situações reais são vivenciadas de maneira lúdica, permitindo aos jogadores experienciarem várias realidades."),
                    new AfirmacaoSobreMidia(false, "Os jogos se configuram como um meio pedagógico versátil, através do qual os conhecimentos individuais se desenvolvem sem a necessidade de interações."),
                    new AfirmacaoSobreMidia(false, "Os Jogos Digitais são desenvolvidos para serem jogados num console, então para permitir o seu uso em sala de aula torna-se necessário um grande investimento em equipamentos e dispositivos tecnológicos."),
                    new AfirmacaoSobreMidia(false, "Os jogos digitais são utilizados principalmente para produção de conteúdo textual e visual."),
                    new AfirmacaoSobreMidia(false, "São Softwares com o objetivo de auxiliar o usuário professor a desenvolver e distribuir conteúdos diversos para cursos online e disciplinas semipresenciais para alunos em geral."),
                    new AfirmacaoSobreMidia(false, "Os jogos digitais são softwares desenvolvidos com o objetivo de auxiliar o usuário a desempenhar uma tarefa como: enviar um e-mail,  acessar alguma informação, entre outras."),
                });
                break;
            case NomeDeMidia.EditoresDeAudioEVideo:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "Os editores de áudio e vídeo são ferramentas que instigam a pesquisa em sala de aula."),
                    new AfirmacaoSobreMidia(true, "Ao construir utilizando editores de áudio e vídeo podemos incentivar a reflexão de diferentes temas, criatividade e trabalho em equipe dos envolvidos."),
                    new AfirmacaoSobreMidia(true, "Para fazer seus vídeos ou áudios, os alunos precisaram exercitar interação e interatividade e pensar em formas diferentes e dinâmicas de transmitir o que eles querem dizer."),
                    new AfirmacaoSobreMidia(true, "São softwares que proporcionam a edição de conteúdos que contenham som e imagem."),
                    new AfirmacaoSobreMidia(true, "Com esses editores é possível cortar, copiar e colar trechos de áudio e video, bem como aplicar efeitos diversos."),
                    new AfirmacaoSobreMidia(true, "São mídias digitais de produção de conteúdos áudio-visuais que promovem a pesquisa e criatividade."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "São mídias digitais de produção de conteúdos textuais que possibilitam a compilação de dados e informações."),
                    new AfirmacaoSobreMidia(false, "Por ser composto de recursos que possibilitam escolher a fonte, inserir imagens, gráficos e tabelas, o programa é um convite para fomentar a escrita, a leitura e o desenvolvimento da criatividade e aprendizagem colaborativa."),
                    new AfirmacaoSobreMidia(false, "Ao construir utilizando editores de áudio e vídeo podemos incentivar a reflexão de diferentes temas e promover a criatividade, porém somente em atividades individuais."),
                    new AfirmacaoSobreMidia(false, "É uma mídia digital de exposição de conteúdos de imagem e som."),
                });
                break;
            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "Os editores de texto e planilhas eletrônicas permitem uma aprendizagem interativa, rica e que os alunos sejam protagonistas da própria aprendizagem."),
                    new AfirmacaoSobreMidia(true, "Fornecem páginas em branco onde é possível criar, formatar, editar, salvar documentos eletrônicos, misturando elementos visuais e verbais."),
                    new AfirmacaoSobreMidia(true, "Por ser composto de recursos que possibilitam escolher a fonte, inserir imagens, gráficos e tabelas, o programa é um convite para fomentar a escrita, a leitura e o desenvolvimento da criatividade e aprendizagem colaborativa."),
                    new AfirmacaoSobreMidia(true, "Softwares que permitem a edição ou criação de conteúdos que estejam em formato de texto ou planilhas."),
                    new AfirmacaoSobreMidia(true, "Os editores contém diversas ferramentas para personalizar seu conteúdo, como definição de cores, fonte, espaçamentos e muito mais."),
                    new AfirmacaoSobreMidia(true, "Os editores de texto e planilhas eletrônicas são mídias digitais de produção de texto que dão espaço para a construção própria do aluno."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "São mídias digitais de produção de conteúdos áudio-visuais que promovem a pesquisa e criatividade."),
                    new AfirmacaoSobreMidia(false, "Os editores de texto e planilhas eletrônicas permitem uma aprendizagem interativa, rica e que coloca o professor no centro da aprendizagem."),
                    new AfirmacaoSobreMidia(false, "Os editores de texto e planilhas permitem interações por escrito por meio de suas diversas ferramentas (fórum, chat, mensagens, carregamento de arquivos) que enriquecem a aprendizagem em seu resultado, e no próprio processo de sua construção."),
                    new AfirmacaoSobreMidia(false, "Os editores de texto e planilhas permitem conhecer diferentes lugares do mundo e facilitar a distribuição de atividades, dentro e fora da sala de aula."),
                });
                break;
            case NomeDeMidia.AVEAs:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "Um AVEA pode ser utilizado como uma plataforma que perpassa todo o processo de aprendizagem de um aluno, no caso de cursos ou disciplinas à distância."),
                    new AfirmacaoSobreMidia(true, "Um AVEA pode ser utilizado como um recurso didático no planejamento de atividades semi-presenciais."),
                    new AfirmacaoSobreMidia(true, "Um AVEA pode ser utilizado para complementar aulas presenciais com conteúdos virtuais."),
                    new AfirmacaoSobreMidia(true, "No AVEA ocorrem trocas de materiais de estudo, textuais ou áudiovisuais e disponibilizam-se tarefas."),
                    new AfirmacaoSobreMidia(true, "O AVEA permite interações por escrito por meio de suas diversas ferramentas (fórum, chat, mensagens, carregamento de arquivos) que enriquecem a aprendizagem não só no seu resultado, mas no próprio processo de sua construção."),
                    new AfirmacaoSobreMidia(true, "São Softwares com o objetivo de auxiliar o usuário professor a desenvolver e distribuir conteúdos diversos para cursos online e disciplinas semipresenciais para alunos em geral."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Um AVEA pode ser utilizado como uma plataforma que perpassa todo o processo de aprendizagem de um aluno, porém somente em disciplinas à distância."),
                    new AfirmacaoSobreMidia(false, "Um AVEA não pode ser utilizado para complementar aulas presenciais precisando ser utilizado apenas no ensino à distância."),
                    new AfirmacaoSobreMidia(false, "São Softwares que surgiram com a função de entretenimento, mas podem ser adaptados com o objetivo de auxiliar o usuário professor a desenvolver e distribuir conteúdos diversos para cursos online e disciplinas semipresenciais."),
                    new AfirmacaoSobreMidia(false, "Os AVEAs precisam da intervenção simultânea do professor com os alunos para poder ser efetivo."),
                });
                break;
            case NomeDeMidia.Aplicativos:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    // Afirmações verdadeiras
                    new AfirmacaoSobreMidia(true, "Tanto para alunos quanto para professores, os aplicativos tornaram-se uma das principais ferramentas para aprender e ensinar com mais facilidade."),
                    new AfirmacaoSobreMidia(true, "O trabalho com aplicativos permite hibridez e personalização do ensino, e trazem diversos benefícios como: ajudar a organizar suas tarefas, aprender algum idioma, criar um ambiente de estudo para educadores e alunos."),
                    new AfirmacaoSobreMidia(true, "Os aplicativos permitem conhecer diferentes lugares do mundo e facilitar a distribuição de atividades, dentro e fora da sala de aula."),
                    new AfirmacaoSobreMidia(true, "Os aplicativos aproximam o aluno de ferramentas utilizadas em diferentes segmentos e finalidades da sociedade, incluindo-o no mundo digital."),
                    new AfirmacaoSobreMidia(true, "Os aplicativos são softwares com o objetivo de auxiliar o usuário a desempenhar uma tarefa, enviar um e-mail, ou acessar alguma informação, como o GPS, entre outros."),
                    new AfirmacaoSobreMidia(true, "Os aplicativos são mídias digitais extremamente flexíveis que dependendo da sua elaboração podem auxiliar na organização, pesquisa e consulta de dados."),
                    // Afirmações falsas
                    new AfirmacaoSobreMidia(false, "Os aplicativos precisam ser muito adaptados para poder funcionar no processo de ensino e aprendizagem."),
                    new AfirmacaoSobreMidia(false, "Os aplicativos são ótimos para aprender em ambientes informais, mas na educação formal torna-se necessário a utilização de ferramentas criadas com o objetivo de ensinar."),
                    new AfirmacaoSobreMidia(false, "Os alunos podem aprender sozinhos ao utilizar aplicativos, ficando no centro do processo de aprendizagem e tornando obsoleta a figura do professor."),
                    new AfirmacaoSobreMidia(false, "Os aplicativos são mídias de exposição, utilizadas principalmente para os alunos ter o primeiro contato com o conteúdo que será aprendido."),
                });
                break;
            default:
                Debug.LogError("Não há nenhuma afirmação definida para a mídia '" + midia.ToString() + "'");
                return null;
        }
        var afirmacoes = lista.ToArray();
        for (var i = 0; i < afirmacoes.Length; i++)
        {
            afirmacoes[i].NomeDaMidia = midia;
        }
        return afirmacoes;
    }

    private AfirmacaoSobreMidia(bool verdadeira, string texto) : base(verdadeira, texto) { }
}

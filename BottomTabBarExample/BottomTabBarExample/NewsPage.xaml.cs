using BottomTabBarExample.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            PopulateNews();
        }

        public void PopulateNews()
        {
            List<Noticias> noticias = new List<Noticias>();

            noticias.Add(new Noticias()
            {
                titulo = "Parto Humanizado",
                descricao = "O Parto Humanizado não é um tipo de parto e sim o processo de tornar o parto mais humano onde a protagonista é a gestante e seu filho que está para nascer. Há muita polêmica sobre o que é um parto humanizado, mas a maioria aceita que é aquele em que as decisões da mulher são levadas muito mais em conta do que em um parto convencional. Isso significa deixar a natureza fazer o seu trabalho, realizar um mínimo de intervenções médicas e apenas as autorizadas pela gestante – sempre levando em consideração a segurança e saúde dela e do bebê. Para isso acontecer, é preciso que ambos estejam bem e saudáveis, sem nada que exija cuidados extras. Segundo a Organização Mundial de Saúde, o parto humanizado promove incentivo ao parto vaginal; incentivo ao aleitamento materno; alojamento conjunto com o bebê; presença de acompanhante; redução de intervenções tecnológicas desnecessárias como a episiotomia; estímulo às técnicas mecânicas de alívio da dor (massagens, banhos, caminhar livremente). No parto humanizado, o bem-estar da gestante e do bebê são colocados em primeiro lugar. A mulher tem autonomia para decidir sobre os procedimentos adotados e os envolvidos têm o dever de garantir que ela esteja num ambiente seguro, acolhedor e tranquilo.O parto humanizado também é vantajoso para o bebê. Ele vai diretamente para os braços da mãe e pode mamar logo que nasce. Esse primeiro contato é muito importante para ambos.",
                imagem = ImageSource.FromFile("PartoHumanizado.png")
            });
            noticias.Add(new Noticias()
            {
                titulo = "Violência obstétrica: saiba o que é e como denunciar",
                descricao = "Agressões verbais, recusa de atendimento, privação de acompanhante, lavagem intestinal, raspagem dos pelos, jejum, episiotomia e separação de mãe e bebê saudável após o nascimento estão entre os itens da gigante lista de violências obstétricas. O conceito é amplo, mas visa categorizar todos os procedimentos, físicos ou não, pelos quais as mulheres passam na gestação, trabalho de parto, parto, pós-parto e abortamento que não são preconizados pelos princípios da humanização e da medicina baseada em evidências. A violência é rotineira nos hospitais e maternidades, mas, além do empenho das ativistas, ações do Ministério Público podem melhorar o cenário obstétrico do Brasil. Negar atendimento, impor dificuldades ao atendimento em postos de saúde durante o pré-natal, realizar comentários constrangedores ou que propaguem o preconceito de raça, classe social, escolaridade, religião, estado civil, orientação sexual e número de filhos, sofrer humilhações ou negligências no atendimento e ter a cesárea agendada sem recomendação baseada em evidências científicas por pura conveniência e interesse médico estão entre as violências sofridas durante a gestação segundo o Ministério Público. Para denunciar uma violência obstétrica, basta procurar a Defensoria Pública do município com cópia do prontuário médico, documento que registra todos os procedimentos pelos quais a mulher foi submetida desde que chegou ao hospital ou maternidade. Para obtê-lo é preciso procurar o setor administrativo da instituição e solicitá-lo. O único custo que pode ser cobrado é o de cópia das folhas.",
                imagem = ImageSource.FromFile("violencia.jpg")
            });
            noticias.Add(new Noticias()
            {
                titulo = "Doulas",
                descricao = "Doulas são mulheres que dão suporte fisico e emocional às gestantes. Esse pode ocorrer durante a gravidez ou depois do parto. É ela quem dá orientações ao casal a respeito do parto, explica procedimentos e ajuda a mulher se preparar fisicamente e emocionalmente para o momento do parto. Durante o parto, a doula fica ao lado da mãe oferecendo apoio emocional e tranquilidade, ajuda a mãe a encontrar posições mais confortáveis e dá dicas de técnicas de respiração que diminuam a dor. Após o parto, a doula pode auxiliar a mãe com orientações sobre cuidados com o recém nascido e amamentação.",
                imagem = ImageSource.FromFile("doulas.png")
            });

            noticias.Add(new Noticias()
            {
                titulo = "Exercícios de Kegel",
                descricao = "A grávida pode fazer exercícios para fortalecer os músculos do assoalho pélvico, como fazer exercícios de Kegel, facilitando o momento de expulsão do feto. Desta forma, a gestante deve contrair e puxar para cima os músculos o máximo que conseguir, mantendo - se assim pelo maior tempo possível e depois relaxar os músculos, baixando as pernas e as costas.",
                imagem = ImageSource.FromFile("exercicios1.png")
            });
            noticias.Add(new Noticias()
            {
                titulo = "Dançar",
                descricao = "Para facilitar o trabalho de parto, a grávida pode dançar ou apenas rebolar, o que pode facilitar o parto, pois o movimento da grávida promove o movimento do bebê na barriga, facilitando o parto.",
                imagem = ImageSource.FromFile("exercicios2.png")
            });
            lvNoticias.ItemsSource = noticias;
        }
    }
}
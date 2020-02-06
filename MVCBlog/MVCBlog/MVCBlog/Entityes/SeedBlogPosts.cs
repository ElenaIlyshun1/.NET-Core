using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBlog.Entityes
{
    public class SeedBlogPosts
    {
        public static void SeedBlogData(DBContext context)
        {
            if (!context.Blog.Any())
            {
                context.Blog.AddRange(
                new BlogModel
                {
                    author = "Neo",
                    title = "RESUME VS COVER LETTER: MAIN DIFFERENCES BETWEEN",
                    preview = "Do you know that a resume and a cover letter actually differ? Even though both of" +
                    " these documents are essential when applying for a job, it is critical that you know how to " +
                    "differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you",
                    fullPost = "Do you know that a resume and a cover letter actually differ? Even though both of " +
                    "these documents are essential when applying for a job, it is critical that you know how to" +
                    " differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you understand what aim each of them has. When writing either a" +
                    " resume or a cover letter, you should demonstrate your skills and competencies in order to prove" +
                    " to the employer or HR manager that you are worth being considered for the position. Ideally," +
                    " both a resume and a cover letter should pinpoint that you have skills that are relevant and " +
                    "corresponding to the job opening. As you start working on the resume or a cover letter, " +
                    "be sure that you should come to realize the resume vs cover letter structure and mode or " +
                    "organization.Moreover,it is essential to adhere to the template and follow the general" +
                    " requirements as well as the resume cover letter format. First of all, a resume and a cover " +
                    "letter are not the same and each of them has a different structure and purpose.Second",
                    img = "/img/1.jpg"
                }, 
                new BlogModel
                {
                    author = "Наталя ФЕЩИК",
                    title = "Там, де починається і закінчується життя",                  
                    preview = "Діяльність системи державних органів,в яких в юридичному сенсі починається і закінчується життя,"+
                    "показує,що ми таки на вірному шляху.",
                    fullPost = "Українські громадяни і європейське співтовариство протягом останніх десятків років спостерігають,"+
                    "як нібито здійснюється реформування органів державної влади.Хоча насправді не багатьом органам приділяється увага." +
                    "На слуху переважно  перебудова судової та правоохоронної систем.Але досить швидкими темпами оновлюється система" +
                    "діяльності інших органів державного апарату.Чи не найважливішим для кожної людини є орган реєстрації актів цивільного стану." +
                    "Адже саме сюди ми ідемо при найзнаковіших подіях у нашому житті.Це створення сім’ї  і реєстрація народження дитини.Реєстрація " +
                    "припинення таких само важливих подій,як розірвання шлюбу чи смерть.Працівники РАЦС поряд з нами і в радості," +
                    "і в печалі.Мають бути водночас юристами, діловодами і навіть психологами.І неформально, не як чуже сприймати найщасливіші і найскорботніші події нашого життя," +
                    "коли ми так потребуємо розуміння,співучасті чи навіть співчуття.А головне – належного  і  комфортного отримання послуги, тобто просто хорошого сервісу.",
                    img = "/img/2.jpg"
                },
                new BlogModel
                {
                    author = "Олександр НАРОВЛЯНСЬКИЙ",
                    title = "Что может ребенок до 14 лет",
                    preview = "До 14 лет ребенок (малолетнее лицо, в соответствии с законом) фактически имеет только одно право в гражданских правоотношениях " +
                    "– он может совершать мелкие бытовые сделки.",
                    fullPost = "Детвора очень часто задает вопрос: что такое мелкие бытовые сделки? На самом деле, достаточно четкого, однозначного определения в законе" +
                    "нет – там указано, что сделка является мелкой бытовой. Гражданский кодекс говорит, что сделка является мелкой бытовой, если она удовлетворяет бытовые" +
                    "потребности лица, соответствует ее физическому,  духовному или социальному развитию и касается предмета, имеющего небольшую стоимость.То есть мелкая" +
                    "бытовая сделка – это то,что, во - первых,имеет незначительную стоимость,что можно оценивать по - разному.И второе – то, что предназначено для повседневного использования," +
                    "то есть компьютер вряд ли будет относиться к таким вещам,ручка,скорее всего,да,а вот что касается телефона,здесь уже можно будет поспорить,в зависимости от того,какой это телефон," +
                    "какова его стоимость и насколько это много для конкретной семьи.К сожалению, никто не может четко сказать, о какой сумме идет речь,если мы говорим о мелкой бытовой сделке.Для одной" +
                    "семьи обычная ручка будет соответствовать понятию мелкая бытовая сделка,а для ребенка,которому ежедневно дают на карманные расходы 100 долларов,наверное,и телефон может" +
                    "рассматриваться как предмет мелкой  бытовой сделки.Поэтому вопрос мелкой бытовой сделки - это вопрос оценочного суждения и в случае возникновения спора,суд примет решение" +
                    "исходя из обстоятельств дела - характера сделки, ее суммы,ценности этой суммы для ребенка и для семьи.Поэтому ответить на этот вопрос однозначно невозможно.",
                    img = "/img/3.jpg"
                } ,
                new BlogModel
                {
                    author = "Neo",
                    title = "RESUME VS COVER LETTER: MAIN DIFFERENCES BETWEEN",
                    preview = "Do you know that a resume and a cover letter actually differ? Even though both of" +
                    " these documents are essential when applying for a job, it is critical that you know how to " +
                    "differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you",
                    fullPost = "Do you know that a resume and a cover letter actually differ? Even though both of " +
                    "these documents are essential when applying for a job, it is critical that you know how to" +
                    " differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you understand what aim each of them has. When writing either a" +
                    " resume or a cover letter, you should demonstrate your skills and competencies in order to prove" +
                    " to the employer or HR manager that you are worth being considered for the position. Ideally," +
                    " both a resume and a cover letter should pinpoint that you have skills that are relevant and " +
                    "corresponding to the job opening. As you start working on the resume or a cover letter, " +
                    "be sure that you should come to realize the resume vs cover letter structure and mode or " +
                    "organization.Moreover,it is essential to adhere to the template and follow the general" +
                    " requirements as well as the resume cover letter format. First of all, a resume and a cover " +
                    "letter are not the same and each of them has a different structure and purpose.Second",
                    img = "/img/4.jpg"
                },
                new BlogModel
                {
                    author = "Neo",
                    title = "RESUME VS COVER LETTER: MAIN DIFFERENCES BETWEEN",
                    preview = "Do you know that a resume and a cover letter actually differ? Even though both of" +
                    " these documents are essential when applying for a job, it is critical that you know how to " +
                    "differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you",
                    fullPost = "Do you know that a resume and a cover letter actually differ? Even though both of " +
                    "these documents are essential when applying for a job, it is critical that you know how to" +
                    " differentiate them in order to write them for the right purpose. Resume vs cover letter should" +
                    " be properly defined so that you understand what aim each of them has. When writing either a" +
                    " resume or a cover letter, you should demonstrate your skills and competencies in order to prove" +
                    " to the employer or HR manager that you are worth being considered for the position. Ideally," +
                    " both a resume and a cover letter should pinpoint that you have skills that are relevant and " +
                    "corresponding to the job opening. As you start working on the resume or a cover letter, " +
                    "be sure that you should come to realize the resume vs cover letter structure and mode or " +
                    "organization.Moreover,it is essential to adhere to the template and follow the general" +
                    " requirements as well as the resume cover letter format. First of all, a resume and a cover " +
                    "letter are not the same and each of them has a different structure and purpose.Second",
                    img = "/img/5.jpg"
                });
            }
            context.SaveChanges();
        }
    }
}

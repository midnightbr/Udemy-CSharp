using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio005.Entities {
    public class Post {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() {
        }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        /**
         * Padrão criar as operações de add e remove de atributos quando se usa List,
         * mesmo que ambos não estejam criados no diagrama.
         */
        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        // Utilizando string builder para o objeto em string
        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(Title);
            builder.Append($"{Likes} Likes - ");
            builder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.AppendLine(Content);
            builder.AppendLine("Comments:");
            // Adicionando comentarios da lista na tela
            foreach (Comment cm in Comments) {
                builder.AppendLine(cm.Text);
            }
            // Retornando os dados do Post já formatados
            return builder.ToString();
        }
    }
}

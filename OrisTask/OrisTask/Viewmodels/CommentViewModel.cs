﻿using Domain.Entities;

namespace OrisTask.Viewmodels
{
    public class CommentViewModel
    {
        public CommentViewModel(Comment comment)
        {
            CommentAuthor = comment.CommentAuthor;
            CommentTime = comment.CommentTime;
            CommentText = comment.CommentText;
        }

        public string CommentAuthor { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentText { get; set; }
    }
}

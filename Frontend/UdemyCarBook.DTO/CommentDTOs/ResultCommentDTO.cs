﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.DTO.CommentDTOs;
public class ResultCommentDTO
{
    public int CommentId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Description { get; set; }
    public string Mail { get; set; }
    public bool IsApproved { get; set; }
    public int BlogID { get; set; }
}

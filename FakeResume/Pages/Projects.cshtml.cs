// Projects.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeTemplater.Models;

namespace ResumeTemplater.Pages
{
	public class ProjectsModel : PageModel
	{
  
		public List<Project> Projects { get; set; }

    public string GithubUsername {get; set;}
    
		public void OnGet()
		{
			Projects = new List<Project> {
				new Project()
				{
					Title = "Chess Application",
					Description = "A chess application developed using Java and Swing, with a working GUI and minimalist AI functionality.",
					Year = 2021
				},
				new Project()
				{
					Title = "Mentor Matching",
					Description = "A web application that matches mentors and mentees, developed using Spring Boot and React.JS.",
					Year = 2022
				},
				new Project()
				{
					Title = "Laser Welding Classification",
					Description = "A research-based machine learning project, analysing the efficacy of various ensemble and deep learning models on the classification of welding defects. Developed using Python, SkLearn and Keras.",
					Year = 2023
				},
        new Project() {
          Title = "Spotivise",
          Description = "Spotivize is a music platform that uses geolocation to track when your favorite artists are playing in your local city! Built with Node, Express, React and MongoDB.",
          Year = 2016
        }
			};

      GithubUsername = "aaronchellam";
		}
	}
}

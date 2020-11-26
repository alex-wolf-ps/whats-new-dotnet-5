using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly ILogger<MenuController> _logger;
        private List<MenuItem> MenuItems { get; set; }

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            MenuItems = new List<MenuItem>() {
                new MenuItem()
                {
                    Id = 6,
                    Name = "Cupcake",
                    Summary = "Vanilla cupcakes with the perfect level of sweetness.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cupcake.png",
                    Price = 4,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Muffin",
                    Summary = "A freshly baked chocolate chip muffin - the perfect way to start a Monday morning.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/muffin.png",
                    Price = 3,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Chocolate Bites",
                    Summary = "Rich and sweet chocolate bites for those in need of a special treat.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/chocolate.png",
                    Price = 5,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 1,
                    Name = "Frosted Pumpkin Bread",
                    Slug = "pumpkin-bread",
                    Summary = "A seasonal delight we offer every autumn.  Pumpking bread with just a bit of spice, cream cheese frosting with just a hint of home.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/pumpkinbread.png",
                    Price = 4,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Granola with Nuts",
                    Summary = "It's not flashy, but it sure is healthy.  Perfect for when you need the calories, but not the guilt.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/granola.png",
                    Price = 3,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 4,
                    Name = "Chocolate Chip Cookies",
                    Summary = "They're made fresh every day, and they taste like it..",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cookies.png",
                    Price = 2,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 5,
                    Name = "Fresh Bagels",
                    Summary = "They're just as round as donuts, but far more healthy! Freshly made every morning before sunrise.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/bagel.png",
                    Price = 5,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 6,
                    Name = "Fresh Fruit",
                    Summary = "We've got strawberries, blueberries, apples, bananas - we could list them all, but we'd prefer you come take a look!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/strawberries.png",
                    Price = 5,
                    Category = "Food"
                },
                new MenuItem()
                {
                    Id = 1,
                    Name = "Dark Brewed Coffee",
                    Slug = "dark-brew",
                    Summary = "A classic, refreshing original.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/ground.png",
                    Price = 2,
                    Category = "Coffee"
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Latte",
                    Summary = "More than just coffee, but still just coffee.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cappucino.png",
                    Price = 3,
                    Category = "Coffee"
                },
                new MenuItem()
                {
                    Id = 2,
                    Name = "Americano",
                    Slug = "ground-coffee",
                    Summary = "Still classic, but a little more sophisticated.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/beans.jpg",
                    Price = 4,
                    Category = "Coffee"
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Cappucino",
                    Summary = "Rich and foamy, its the perfect comfort-coffee.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "images/menu/cup.png",
                    Price = 4,
                    Category = "Coffee"
                } };

            return MenuItems;
        }
    }
}

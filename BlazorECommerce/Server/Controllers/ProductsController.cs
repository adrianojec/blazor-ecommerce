using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class ProductsController : ControllerBase
   {
      private static List<Product> Products = new List<Product>
      {
        new Product
        {
            Id = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy is the first book in the Hitchhiker's Guide to the Galaxy comedy science fiction \"trilogy of five books\" by Douglas Adams, with a sixth book written by Eoin Colfer. The novel is an adaptation of the first four parts of Adams's radio series of the same name, centering on the adventures of the only man to survive the destruction of Earth; while roaming outer space, he comes to learn the truth behind Earth's existence. The novel was first published in London on 12 October 1979.[2] It sold 250,000 copies in the first three months.[3]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id = 2,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
            Price = 8.99m
        },
        new Product
        {
            Id = 3,
            Title = "The Lion King",
        Description = "The Lion King is a 1994 American animated musical drama film[4] produced by Walt Disney Feature Animation and released by Walt Disney Pictures. The 32nd Disney animated feature film and the fifth produced during the Disney Renaissance, it is inspired by William Shakespeare's Hamlet with elements from the Biblical stories of Joseph and Moses and Disney's 1942 film Bambi. ",
        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3d/The_Lion_King_poster.jpg",
        Price = 7.99m
        }
      };

      [HttpGet]
      public async Task<ActionResult<List<Product>>> GetAll()
      {
         return Ok(Products);
      }
   }
}
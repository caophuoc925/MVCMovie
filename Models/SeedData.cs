using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                // if (context.MovieNew_.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.MovieNew_.AddRange(
                //     new Movie
                //     {
                //         Title = "When Harry Met Sally",
                //         ReleaseDate = DateTime.Parse("1989-2-12"),
                //         Genre = "Romantic Comedy",
                //         Rating = "R",
                //         Price = 7.99M
                //     },

                //         new Movie
                //         {
                //             Title = "Ghostbusters ",
                //             ReleaseDate = DateTime.Parse("1984-3-13"),
                //             Genre = "Comedy",
                //             Rating = "R",
                //             Price = 8.99M
                //         },

                //         new Movie
                //         {
                //             Title = "Ghostbusters 2",
                //             ReleaseDate = DateTime.Parse("1986-2-23"),
                //             Genre = "Comedy",
                //             Rating = "R",
                //             Price = 9.99M
                //         },

                //         new Movie
                //         {
                //             Title = "Rio Bravo",
                //             ReleaseDate = DateTime.Parse("1959-4-15"),
                //             Genre = "Western",
                //             Rating = "R",
                //             Price = 3.99M
                //         },
                //         new Movie
                //         {
                //             Title = "When Harry Met Sally",
                //             ReleaseDate = DateTime.Parse("1989-2-12"),
                //             Genre = "Romantic Comedy",
                //             Rating = "R",
                //             Price = 7.99M
                //         }
                //     );
                //     context.SaveChanges();
                // }
                using (var context_Student = new MvcMovieContext(
                                serviceProvider.GetRequiredService<
                                    DbContextOptions<MvcMovieContext>>()))
                {
                    //     // Look for any movies.
                    //     if (context_Student.StudentsDatas.Any())
                    //     {
                    //         return;   // DB has been seeded
                    //     }

                    //     context_Student.StudentsDatas.AddRange(
                    //         new StudentsData
                    //         {
                    //             Name = "Phuoc ",
                    //             Address = "Ha Noi ",
                    //         },

                    //       new StudentsData
                    //       {
                    //           Name = "Phuoc ",
                    //           Address = "Ha Noi ",
                    //       },

                    //        new StudentsData
                    //        {
                    //            Name = "Phuoc ",
                    //            Address = "Ha Noi ",
                    //        },

                    //       new StudentsData
                    //       {
                    //           Name = "Phuoc ",
                    //           Address = "Ha Noi ",
                    //       },
                    //       new StudentsData
                    //         {
                    //            Name = "Phuoc ",
                    //            Address = "Ha Noi ",
                    //         }
                    //     );
                    //     context_Student.SaveChanges();
                    // }

                    // Person
                    using (var context_person = new MvcMovieContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<MvcMovieContext>>()))
                    {
                        if (context_person.Person.Any())
                        {
                            return;   // DB has been seeded
                        }

                        context_person.Person.AddRange(
                            new Person
                            {
                                PersonName = "Ph?????c"
                            },
                            new Person
                            {
                                PersonName = "Ph?????c"
                            },
                            new Person
                            {
                                PersonName = "Ph?????c"
                            },
                            new Person
                            {
                                PersonName = "Ph?????c"
                            },
                            new Person
                            {
                                PersonName = "Ph?????c"
                            }
                        );
                        context_person.SaveChanges();
                    }

                    // Employee
                    using (var context_employee = new MvcMovieContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<MvcMovieContext>>()))

                    {
                        if (context_employee.Employee.Any())
                        {
                            return;   // DB has been seeded
                        }

                        context_employee.Employee.AddRange(
                            new Employee
                            {
                                EmployeeID = "epl001",
                                EmployeeName = "Ph?????c",
                                PhoneNumber = 123
                            },
                            new Employee
                            {
                                EmployeeID = "epl002",
                                EmployeeName = "Ph?????c",
                                PhoneNumber = 123
                            },
                            new Employee
                            {
                                EmployeeID = "epl003",
                                EmployeeName = "Ph?????c",
                                PhoneNumber = 123
                            },
                            new Employee
                            {
                                EmployeeID = "epl004",
                                EmployeeName = "Ph?????c",
                                PhoneNumber = 123
                            },
                            new Employee
                            {
                                EmployeeID = "epl005",
                                EmployeeName = "Ph?????c",
                                PhoneNumber = 123
                            },
                            new Employee
                            {
                                EmployeeID = "epl006",
                                EmployeeName = "Ph?????c",
                                PhoneNumber = 123
                            }
                        );
                        context_employee.SaveChanges();
                    }

                    // using (var context_product = new MvcMovieContext(
                    //        serviceProvider.GetRequiredService<
                    //            DbContextOptions<MvcMovieContext>>()))
                    // {
                    //     if (context_product.Product.Any())
                    //     {
                    //         return;   // DB has been seeded
                    //     }

                    //     context_product.Product.AddRange(
                    //         new Product
                    //         {
                    //             ProductId = "prd001",
                    //             ProductName = "B??nh",
                    //             UnitPrice = 2,
                    //             Quantity = 1000
                    //         },
                    //         new Product
                    //         {
                    //             ProductId = "prd002",
                    //             ProductName = "B??nh",
                    //             UnitPrice = 2,
                    //             Quantity = 2000
                    //         },
                    //         new Product
                    //         {
                    //             ProductId = "prd003",
                    //             ProductName = "B??nh",
                    //             UnitPrice = 2,
                    //             Quantity = 3000
                    //         },
                    //         new Product
                    //         {
                    //             ProductId = "prd004",
                    //             ProductName = "B??nh",
                    //             UnitPrice = 2,
                    //             Quantity = 4000
                    //         },
                    //         new Product
                    //         {
                    //             ProductId = "prd005",
                    //             ProductName = "B??nh",
                    //             UnitPrice = 2,
                    //             Quantity = 5000
                    //         }
                    //     );
                    // context_product.SaveChanges();
                    // }
                }
            }
        }
    }
}
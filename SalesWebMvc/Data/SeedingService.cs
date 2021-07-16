using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
                return;

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Seller 1", "teste1@gmail.com", new DateTime(1998, 06, 29), 4000.00, d1);
            Seller s2 = new Seller(2, "Seller 2", "teste2@gmail.com", new DateTime(2000, 03, 10), 3000.00, d2);
            Seller s3 = new Seller(3, "Seller 3", "teste3@gmail.com", new DateTime(1995, 04, 20), 1500.00, d3);
            Seller s4 = new Seller(4, "Seller 4", "teste4@gmail.com", new DateTime(1990, 01, 29), 1000.00, d4);
            Seller s5 = new Seller(5, "Seller 5", "teste5@gmail.com", new DateTime(2002, 01, 02), 2000.00, d2);
            Seller s6 = new Seller(6, "Seller 6", "teste6@gmail.com", new DateTime(1990, 01, 29), 1000.00, d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 01), 11000.00, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2017, 10, 02), 10000.00, SalesStatus.Canceled, s1);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2015, 11, 03), 1000.00, SalesStatus.Pending, s1);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2014, 12, 04), 13000.00, SalesStatus.Pending, s1);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2019, 01, 05), 14000.00, SalesStatus.Billed, s2);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2020, 02, 06), 100.00, SalesStatus.Billed, s3);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2021, 04, 07), 11000.00, SalesStatus.Billed, s2);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2010, 03, 08), 20000.00, SalesStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2008, 05, 09), 11000.00, SalesStatus.Billed, s5);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2011, 06, 10), 50.00, SalesStatus.Canceled, s6);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2012, 08, 11), 22000.00, SalesStatus.Billed, s3);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2013, 09, 12), 23000.00, SalesStatus.Billed, s4);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2014, 10, 13), 24000.00, SalesStatus.Billed, s5);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2015, 11, 14), 25000.00, SalesStatus.Pending, s6);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2016, 12, 15), 26000.00, SalesStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15);

            _context.SaveChanges();
        }
    }
}

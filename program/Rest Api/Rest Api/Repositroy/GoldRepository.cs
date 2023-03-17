using Rest_Api.Controllers.Entites;
using Rest_Api.Entites;
using Rest_Api.Repositroy;

namespace Rest_Api.Controllers.GoldRepositroy
{
    public class GoldRepository : IGoldRepository
    {



        JewelleryContext context;
        public GoldRepository(JewelleryContext context)
        {
            this.context = context;
        }
        public void Add(GoldOrnment go)
        {
           
                context.GoldOrnments.Add(go);
                context.SaveChanges();
                // GoldOrments.Add(go);
            
            
        }
        public List<GoldOrnment> display()
        {

            return context.GoldOrnments.ToList();

        }
        public GoldOrnment getbyid(int id)
        {
            return context.GoldOrnments.Find(id);
          

            
        }
        public bool update(int id, GoldOrnment go)
        {
            GoldOrnment found = context.GoldOrnments.Find(id);
            if(found !=null)
            {
                found.Purity= go.Purity;
                found.Description=go.Description;
                context.SaveChanges(true);
                return true;
            }
            return false;
        }
        public bool delete(int id)
        {
            GoldOrnment found = context.GoldOrnments.Find(id);
            if(found !=null)
            {
                context.GoldOrnments.Remove(found);
                context.SaveChanges(true);
                return true;
            }
            return false;

        }



    }
}

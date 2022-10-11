using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mfe_project.sdata
{
    class PKGData
    {
        public String _solutionName, _solutionPath, _mfeV, _author, _publisher, _version, _vtag, _website, _email;
    }

    public class MSLData
    {
        public Guid slID;
        public String solutionName, solutionPath, mfeV, author, publisher, version, vtag, website, email;

        public MSLData(String _solutionName, String _slPath, Guid _slID, String _mfeV, String _author, String _publisher, String  _version, String _vtag, String _website, String _email)
        {
            solutionName = _solutionName;
            solutionPath = _slPath;
            mfeV = _mfeV;
            author = _author;
            publisher = _publisher;
            version = _version;
            vtag = _vtag;
            website = _website;
            email = _email;
        }

        public String buildData()
        {

            var jsonRS = new PKGData
            {
                _solutionPath = solutionPath,
                _mfeV = mfeV,
                _author = author,
                _publisher = publisher,
                _version = version,
                _vtag = vtag,
                _website = website,
                _email = email
            };

            string output = JsonConvert.SerializeObject(jsonRS);


            return output;
        }


    }
}

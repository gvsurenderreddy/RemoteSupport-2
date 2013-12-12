/*
' Copyright (c) 2013  Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using DotNetNuke.Entities.Modules;

namespace LD2.TeamViewer
{
    public class TeamViewerModuleBase : PortalModuleBase
    {
        private static string _email;
        private static string _fileLocation;
        private static string _fileName;
        
        public string Email
        {
            get { return _email; }

            set { _email = value; }
        }
            
        public string FileLocation
        {
            get { return _fileLocation; }

            set { _fileLocation = value; }
        }

        public string FileName
        {
            get { return _fileName; }

            set { _fileName = value; }
        }
    }
}
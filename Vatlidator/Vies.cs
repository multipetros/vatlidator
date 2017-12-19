/* Vatlidator: Vies Class
 * (c) 2011-2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
using System ;
using Vatlidator.ec.europa.eu ;

namespace Vatlidator{
	/// <summary>
	/// Validate EU VAT ID and retrieve info, using EU VIES SOAP service.
	/// </summary>
	public class Vies{
		private bool valid ;
		private string vatId ;
		private string country ;
		private string name ;
		private string address ;
		private string[] supportedCountries = {"AT", "BE", "BG", "CY", "CZ", "DE", "DK", "EE", "EL", "ES", "FI", "FR", "GB", "HR", "HU", "IE", "IT", "LT", "LU", "LV", "MT", "NL", "PL", "PT", "RO", "SE", "SI", "SK"} ;
		private checkVatService checkSercive = new checkVatService() ;
		
		public Vies(){	}
		
		public string VatId{
			get{ return this.vatId ; }
		}
		
		public string Country{
			get{ return this.country ; }
		}
		
		public string[] SupportedCountries{
			get{ return this.supportedCountries ; } 
		}
		
		public string Name{
			get{ return this.name ; }
		}
		
		public string Address{
			get{ return this.address ; }
		}
		
		public bool Valid{
			get{ return this.valid ; }
		}
		
		/// <summary>Perform the validation</summary>
		/// <param name="country">One of Country codes, included in the supportedCountries array</param>
		/// <param name="vatId">The VAT ID to validate</param>
		/// <returns>Vies Object with attributs fullfiled</returns>
		public Vies Validate(string country, string vatId){
			if(Array.IndexOf(this.supportedCountries, country) < 0){
					throw new Exception("Country " + country + " is not supported") ;
			}else{
				this.country = country ; 
			}
			
			this.vatId = vatId ;
			checkSercive.checkVat(ref this.country, ref this.vatId, out this.valid, out this.name, out this.address) ;
			return this ;
		}
	}
}

package cau2;


/**
 * @author User
 * @version 1.0
 * @created 20-Feb-2023 11:21:08 PM
 */
public abstract class HInh {

	protected string ten;
	protected Diem m_diem[];

	public Hinh(){

	}

	public void finalize() throws Throwable {

	}

	public abstract double chuvi();

	public abstract double dientich();

	public string docten(){
		return "";
	}

	/**
	 * 
	 * @param t
	 */
	public void ganten(string t){

	}

	public Diem[] getdiem(){
		return m_diem;
	}

	/**
	 * 
	 * @param newVal
	 */
	public void setdiem(Diem newVal[]){
		m_diem = newVal;
	}




}
package Cau4;


/**
 * @author ASUS
 * @version 1.0
 * @created 28-Feb-2023 2:52:28 PM
 */
public class Student extends User {

	public Course m_Course;

	public Student(){

	}

	public void finalize() throws Throwable {
		super.finalize();
	}

	/**
	 * 
	 * @param course
	 */
	public abstract void doTest(Course course);

	/**
	 * 
	 * @param ourse
	 */
	public void register(Course ourse){

	}

	/**
	 * 
	 * @param course
	 */
	public void study(Course course){

	}

	/**
	 * 
	 * @param doc cou
	 */
	public void submitExercise(Document, Course doc cou){

	}

	/**
	 * 
	 * @param course
	 */
	public void viewResult(Course course){

	}

}
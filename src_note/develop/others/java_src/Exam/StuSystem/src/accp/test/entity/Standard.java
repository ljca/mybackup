package accp.test.entity;
import java.util.Date;

public class Standard {
	/*
	 * id
	 * stdNum
	 * zhname
	 * version
	 * keys
	 * releaseDate
	 * implDate
	 * package
	 */

	private int id;
	
	private String stdNum;
	
	private String zhname;
	
	private String version;
	
	private String keys;
	
	private Date releaseDate;
	
	private Date implDate;
	
	private String packAge;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getStdNum() {
		return stdNum;
	}

	public void setStdNum(String stdNum) {
		this.stdNum = stdNum;
	}

	public String getZhname() {
		return zhname;
	}

	public void setZhname(String zhname) {
		this.zhname = zhname;
	}

	public String getVersion() {
		return version;
	}

	public void setVersion(String version) {
		this.version = version;
	}

	public String getKeys() {
		return keys;
	}

	public void setKeys(String keys) {
		this.keys = keys;
	}

	public Date getReleaseDate() {
		return releaseDate;
	}

	public void setReleaseDate(Date releaseDate) {
		this.releaseDate = releaseDate;
	}

	public Date getImplDate() {
		return implDate;
	}

	public void setImplDate(Date implDate) {
		this.implDate = implDate;
	}

	public String getPackAge() {
		return packAge;
	}

	public void setPackAge(String packAge) {
		this.packAge = packAge;
	}
	
}

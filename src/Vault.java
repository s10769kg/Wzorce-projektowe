public class Vault  {
    private static Vault instance;


    private String accessKey;


    private Vault() {
        this.accessKey = "xyz-657-987-klm-3332" ;
    }


    public static Vault getInstance()
    {
        if (instance==null) {
            instance = new Vault();
        }
        return instance;
    }

    public String getAccessKey() {
        String key = this.accessKey;
        this.accessKey = null;
        return key;
    }
}



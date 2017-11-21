using System;

namespace exercise1
{
    public class ObjectHelper
    {
        public static Object GetListObject()
            => new
            {
                name = "Xamarin test 2",
                contact = new
                {
                    company = "Novahub",
                    address1 = "155",
                    address2 = "Nguyen Van Linh",
                    city = "Danang",
                    state = "GA",
                    zip = "550000",
                    country = "VN",
                    phone = ""
                },
                permission_reminder = "Test reminder",
                campaign_defaults = new
                {
                    from_name = "Tran Ngoc Quoc",
                    from_email = "quoctran2124@gmail.com",
                    subject = "MailChimp Demo",
                    language = "en",
                },
                email_type_option = true
            };

        public static object GetCampaignObject(string listId)
            => new
            {
                recipients = new
                {
                    list_id = listId
                },
                type = "regular",
                settings = new
                {
                    subject_line = "Test send email",
                    reply_to = "stevelee2421@outlook.com",
                    from_name = "Quoc Tran"
                }
            };

        public static object GetEmailObject(string email)
            => new
            {
                email_address = email,
                merge_fields =
                new
                {
                    FNAME = "Foo",
                    LNAME = "Bar"
                },
                status_if_new = "subscribed"
            };

        public static object GetContentObject(string content)
            => new
            {
                html = content,
            };
    }
}
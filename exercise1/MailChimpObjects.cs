using System;

namespace exercise1
{
    public class MailChimpObjects
    {
        public static Object CreateListObject()
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

        public static object CreateCampaignObject(string listId)
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

        public static object CreateEmailObject(string email)
            => new
            {
                email_address = email,
                merge_fields =
                new
                {
                    FNAME = "Foo",
                    LNAME = "Bar"
                },
                status = "subscribed"
            };

        public static object CreateContentObject(string content)
            => new
            {
                html = content,
            };
    }
}
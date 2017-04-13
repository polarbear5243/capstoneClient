S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9035
Date: 2017-04-14 03:25:40+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9035, uid 5000)

Register Information
r0   = 0xbea98eec, r1   = 0xd2bdf846
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb276a3f1, r5   = 0xb7718e90
r6   = 0xb7855170, r7   = 0xbea98fd0
r8   = 0x800f85c6, r9   = 0xb5e6d708
r10  = 0xb78d77d0, fp   = 0x00000000
ip   = 0x800f85c6, sp   = 0xbea98fb8
lr   = 0xb276a415, pc   = 0xd2bdf844
cpsr = 0x600f0010

Memory Information
MemTotal:   987012 KB
MemFree:    145848 KB
Buffers:     47812 KB
Cached:     324624 KB
VmPeak:     147656 KB
VmSize:     146368 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30804 KB
VmRSS:       29904 KB
VmData:      47008 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35828 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9035 TID = 9035
9035 9036 9305 9306 9314 

Maps Information
af12e000 af92d000 rw-p [stack:9314]
b0e50000 b0e61000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0e71000 b0e76000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1306000 b130e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1320000 b1b1f000 rw-p [stack:9306]
b1b1f000 b1b20000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b30000 b1b44000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b58000 b1b59000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b69000 b1b6c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b7d000 b1b7e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b8e000 b1b90000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1ba0000 b1ba2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bb2000 b1bc2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bd2000 b1bde000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bf0000 b23ef000 rw-p [stack:9305]
b2720000 b2727000 r-xp /usr/lib/libefl-extension.so.0.1.0
b273a000 b2740000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2750000 b2778000 r-xp /opt/usr/apps/org.example.client/bin/client
b28d1000 b29b4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29eb000 b2a13000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a25000 b3224000 rw-p [stack:9036]
b3224000 b3226000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3236000 b3240000 r-xp /lib/libnss_files-2.20-2014.11.so
b3251000 b325a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b326b000 b327c000 r-xp /lib/libnsl-2.20-2014.11.so
b328f000 b3295000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32a6000 b32a7000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32cf000 b32d6000 r-xp /usr/lib/libminizip.so.1.0.0
b32e6000 b32eb000 r-xp /usr/lib/libstorage.so.0.1
b32fb000 b335a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3370000 b3384000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3394000 b33d8000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33e8000 b33f0000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3400000 b3430000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3443000 b34fc000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3510000 b3563000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3574000 b358f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b359f000 b3660000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3673000 b3683000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3693000 b36a0000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b1000 b36b8000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36c8000 b3709000 r-xp /usr/lib/libmdm.so.1.2.12
b3719000 b3721000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3730000 b3740000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3761000 b37c1000 r-xp /usr/lib/libasound.so.2.0.0
b37d3000 b37d6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37e6000 b37e9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37f9000 b37fe000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b380e000 b380f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b381f000 b382a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b383e000 b3845000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3855000 b385b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b386b000 b3870000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3880000 b389b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ab000 b38b2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c2000 b38c5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38d6000 b3904000 r-xp /usr/lib/libidn.so.11.5.44
b3914000 b392a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b393b000 b3945000 r-xp /usr/lib/libcares.so.2.1.0
b3955000 b395f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b396f000 b3971000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3981000 b3982000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3992000 b3996000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39a7000 b39cf000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e0000 b3a09000 r-xp /usr/lib/libturbojpeg.so
b3a29000 b3a2f000 r-xp /usr/lib/libgif.so.4.1.6
b3a3f000 b3a85000 r-xp /usr/lib/libcurl.so.4.3.0
b3a96000 b3ab7000 r-xp /usr/lib/libexif.so.12.3.3
b3ad2000 b3ae7000 r-xp /usr/lib/libtts.so
b3af8000 b3b00000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b10000 b3bd6000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bf6000 b3cee000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d0d000 b3ddb000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df2000 b3df4000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e04000 b3e0a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e1a000 b3e3d000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e4e000 b3e50000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e60000 b3e62000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e73000 b3e78000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e8f000 b3e91000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea1000 b3ea8000 r-xp /usr/lib/libsensord-share.so
b3eb8000 b3ed0000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee1000 b3ee4000 r-xp /usr/lib/libXv.so.1.0.0
b3ef4000 b3ef9000 r-xp /usr/lib/libutilX.so.1.1.0
b3f09000 b3f0e000 r-xp /usr/lib/libappcore-common.so.1.1
b3f1e000 b3f25000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f38000 b3f3c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f4d000 b402b000 r-xp /usr/lib/libCOREGL.so.4.0
b404b000 b404e000 r-xp /usr/lib/libuuid.so.1.3.0
b405e000 b4075000 r-xp /usr/lib/libblkid.so.1.1.0
b4086000 b4088000 r-xp /usr/lib/libXau.so.6.0.0
b4098000 b40df000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f1000 b40f7000 r-xp /usr/lib/libjson-c.so.2.0.1
b4108000 b410c000 r-xp /usr/lib/libogg.so.0.7.1
b411c000 b413e000 r-xp /usr/lib/libvorbis.so.0.4.3
b414e000 b4232000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b424e000 b4251000 r-xp /usr/lib/libEGL.so.1.4
b4262000 b4268000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4278000 b427a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b428a000 b4297000 r-xp /usr/lib/libGLESv2.so.2.0
b42a8000 b430a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b431f000 b4337000 r-xp /usr/lib/libmount.so.1.1.0
b4349000 b435d000 r-xp /usr/lib/libxcb.so.1.1.0
b436d000 b4374000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ac000 b43ae000 r-xp /usr/lib/libiri.so
b43be000 b43c9000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43da000 b4410000 r-xp /usr/lib/libpulse.so.0.16.2
b4421000 b4464000 r-xp /usr/lib/libsndfile.so.1.0.25
b4479000 b448e000 r-xp /lib/libexpat.so.1.5.2
b44a0000 b455e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4572000 b457a000 r-xp /usr/lib/libdrm.so.2.4.0
b458a000 b458d000 r-xp /usr/lib/libdri2.so.0.0.0
b459d000 b45eb000 r-xp /usr/lib/libssl.so.1.0.0
b4600000 b460c000 r-xp /usr/lib/libeeze.so.1.13.0
b461d000 b4626000 r-xp /usr/lib/libethumb.so.1.13.0
b4636000 b4639000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4649000 b4800000 r-xp /usr/lib/libcrypto.so.1.0.0
b55eb000 b55f4000 r-xp /usr/lib/libXi.so.6.1.0
b5604000 b5606000 r-xp /usr/lib/libXgesture.so.7.0.0
b5616000 b561a000 r-xp /usr/lib/libXtst.so.6.1.0
b562a000 b5630000 r-xp /usr/lib/libXrender.so.1.3.0
b5640000 b5646000 r-xp /usr/lib/libXrandr.so.2.2.0
b5656000 b5658000 r-xp /usr/lib/libXinerama.so.1.0.0
b5669000 b566c000 r-xp /usr/lib/libXfixes.so.3.1.0
b567c000 b5687000 r-xp /usr/lib/libXext.so.6.4.0
b5697000 b5699000 r-xp /usr/lib/libXdamage.so.1.1.0
b56a9000 b56ab000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56bb000 b579d000 r-xp /usr/lib/libX11.so.6.3.0
b57b1000 b57b8000 r-xp /usr/lib/libXcursor.so.1.0.2
b57c8000 b57e0000 r-xp /usr/lib/libudev.so.1.6.0
b57e2000 b57e5000 r-xp /lib/libattr.so.1.1.0
b57f5000 b5815000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5816000 b581b000 r-xp /usr/lib/libffi.so.6.0.2
b582c000 b5844000 r-xp /lib/libz.so.1.2.8
b5854000 b5856000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5866000 b593b000 r-xp /usr/lib/libxml2.so.2.9.2
b5950000 b59eb000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a07000 b5a0a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a1a000 b5a33000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a44000 b5a55000 r-xp /lib/libresolv-2.20-2014.11.so
b5a69000 b5ae3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5af8000 b5afa000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b0a000 b5b11000 r-xp /usr/lib/libembryo.so.1.13.0
b5b21000 b5b2b000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b3c000 b5b54000 r-xp /usr/lib/libpng12.so.0.50.0
b5b65000 b5b88000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ba9000 b5bbd000 r-xp /usr/lib/libector.so.1.13.0
b5bce000 b5be6000 r-xp /usr/lib/liblua-5.1.so
b5bf7000 b5c4e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c62000 b5c8a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5c9b000 b5cae000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cbf000 b5cf9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d0a000 b5d18000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d28000 b5d30000 r-xp /usr/lib/libtbm.so.1.0.0
b5d40000 b5d4d000 r-xp /usr/lib/libeio.so.1.13.0
b5d5d000 b5d5f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d6f000 b5d74000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d84000 b5d9b000 r-xp /usr/lib/libefreet.so.1.13.0
b5dad000 b5dcd000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ddd000 b5dfd000 r-xp /usr/lib/libecore_con.so.1.13.0
b5dff000 b5e05000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e15000 b5e26000 r-xp /usr/lib/libemotion.so.1.13.0
b5e37000 b5e3e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e4e000 b5e5d000 r-xp /usr/lib/libeo.so.1.13.0
b5e6e000 b5e80000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e91000 b5e96000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ea6000 b5ebf000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ecf000 b5eec000 r-xp /usr/lib/libeet.so.1.13.0
b5f05000 b5f4d000 r-xp /usr/lib/libeina.so.1.13.0
b5f5e000 b5f6e000 r-xp /usr/lib/libefl.so.1.13.0
b5f7f000 b6064000 r-xp /usr/lib/libicuuc.so.51.1
b6081000 b61c1000 r-xp /usr/lib/libicui18n.so.51.1
b61d8000 b6210000 r-xp /usr/lib/libecore_x.so.1.13.0
b6222000 b6225000 r-xp /lib/libcap.so.2.21
b6235000 b625e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b626f000 b6276000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6288000 b62bf000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d0000 b63bb000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63ce000 b6447000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6459000 b645e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b646e000 b6478000 r-xp /usr/lib/libvconf.so.0.2.45
b6488000 b648a000 r-xp /usr/lib/libvasum.so.0.3.1
b649a000 b649c000 r-xp /usr/lib/libttrace.so.1.1
b64ac000 b64af000 r-xp /usr/lib/libiniparser.so.0
b64bf000 b64e5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64f5000 b64fa000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650b000 b6522000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6533000 b659e000 r-xp /lib/libm-2.20-2014.11.so
b65af000 b65b5000 r-xp /lib/librt-2.20-2014.11.so
b65c6000 b65d3000 r-xp /usr/lib/libunwind.so.8.0.1
b6609000 b672d000 r-xp /lib/libc-2.20-2014.11.so
b6742000 b675b000 r-xp /lib/libgcc_s-4.9.so.1
b676b000 b684d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b685e000 b6888000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6899000 b68d5000 r-xp /usr/lib/libsystemd.so.0.4.0
b68d7000 b695a000 r-xp /usr/lib/libedje.so.1.13.0
b696d000 b698b000 r-xp /usr/lib/libecore.so.1.13.0
b69ab000 b6b32000 r-xp /usr/lib/libevas.so.1.13.0
b6b67000 b6b7b000 r-xp /lib/libpthread-2.20-2014.11.so
b6b8f000 b6dc3000 r-xp /usr/lib/libelementary.so.1.13.0
b6df2000 b6df6000 r-xp /usr/lib/libsmack.so.1.0.0
b6e06000 b6e0d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e1d000 b6e1f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e2f000 b6e32000 r-xp /usr/lib/libbundle.so.0.1.22
b6e42000 b6e44000 r-xp /lib/libdl-2.20-2014.11.so
b6e55000 b6e6d000 r-xp /usr/lib/libaul.so.0.1.0
b6e81000 b6e86000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e97000 b6ea4000 r-xp /usr/lib/liblptcp.so
b6eb6000 b6eba000 r-xp /usr/lib/libsys-assert.so
b6ecb000 b6eeb000 r-xp /lib/ld-2.20-2014.11.so
b6efc000 b6f01000 r-xp /usr/bin/launchpad-loader
b742a000 b793a000 rw-p [heap]
bea79000 bea9a000 rw-p [stack]
b742a000 b793a000 rw-p [heap]
bea79000 bea9a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9035)
Call Stack Count: 1
 0: (0xd2bdf844) (null)
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
E/AUL_AMD (  616): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1492109690, Fri Apr 14 03:54:50 2017
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1531357133, next duetime: 1492109690
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1531357133)
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1492108317), due_time(1492109690)
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-4-2017, 18:31:57 (UTC).
04-14 03:24:50.053+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-14 03:24:50.063+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-14 03:24:50.063+0900 W/ALARM_MANAGER(  637): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/561/status successfully
04-14 03:24:50.063+0900 W/ALARM_MANAGER(  637): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-14 03:24:50.063+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1531357133) zone(/)
04-14 03:24:50.063+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-14 03:24:50.063+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-4-2017, 18:31:57 (UTC).
04-14 03:24:50.063+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-14 03:24:50.063+0900 E/ALARM_MANAGER(  637): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[1531357133] is removed.
04-14 03:24:50.073+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-14 03:24:50.073+0900 W/ALARM_MANAGER(  637): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/561/status successfully
04-14 03:24:50.073+0900 W/ALARM_MANAGER(  637): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-14 03:24:50.073+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:24:50.073+0900 I/AUL_AMD (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-14 03:24:50.083+0900 I/AUL_AMD (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-14 03:24:50.083+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:24:50.093+0900 I/AUL_AMD (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-14 03:24:50.103+0900 I/AUL_AMD (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-14 03:24:50.103+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 38
04-14 03:24:50.103+0900 E/AUL_AMD (  616): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-14 03:24:50.103+0900 E/AUL_AMD (  616): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1492111490, Fri Apr 14 04:24:50 2017
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1531357133, next duetime: 1492111490
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1531357133)
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1492108317), due_time(1492111490)
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-4-2017, 18:31:57 (UTC).
04-14 03:24:50.103+0900 E/ALARM_MANAGER(  637): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-14 03:25:00.273+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(195) > ""
04-14 03:25:00.273+0900 E/UXT     (  645): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:25
04-14 03:25:00.273+0900 I/INDICATOR(  645): clock.c: getTimeFormatted(176) > "time format : 오전 3:25"
04-14 03:25:00.273+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:25"
04-14 03:25:00.273+0900 W/INDICATOR(  645): clock.c: indicator_clock_changed_cb(272) > 
04-14 03:25:00.273+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145822792 Time: <font_size=31> </font_size> <font_size=31> 오전 3:25</font_size></font>"
04-14 03:25:17.670+0900 E/PKGMGR_SERVER( 9092): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:25:17.720+0900 E/PKGMGR  ( 9090): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-14 03:25:17.750+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 14
04-14 03:25:17.750+0900 W/AUL_AMD (  616): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 8774
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 12
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5519)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.760+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(5519) is dead. cmd(5) is canceled
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): [0;m
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5648)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.760+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(5648) is dead. cmd(5) is canceled
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): [0;m
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5778)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.760+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(5778) is dead. cmd(5) is canceled
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): [0;m
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6394)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.760+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(6394) is dead. cmd(5) is canceled
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): [0;m
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(8127)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.760+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(8127) is dead. cmd(5) is canceled
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): [0;m
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(8496)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.760+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(8496) is dead. cmd(5) is canceled
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:25:17.760+0900 E/PKGMGR_SERVER( 9095): [0;m
04-14 03:25:17.760+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(396) > request cmd(5) to(8774)
04-14 03:25:17.760+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:25:17.770+0900 I/APP_CORE( 8774): appcore-efl.c: __do_app(514) > [APP 8774] Event: TERMINATE State: RUNNING
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(8774), cmd(4)
04-14 03:25:17.770+0900 W/AUL     ( 9095): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 22
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(1201) > app status : 5
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 14
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 22
04-14 03:25:17.770+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(1201) > app status : 5
04-14 03:25:17.780+0900 E/PKGMGR_SERVER( 9092): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9095]
04-14 03:25:17.780+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 8774): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-14 03:25:17.780+0900 E/APP_CORE( 8774): appcore-efl.c: _capture_and_make_file(1619) > win[5e00002] widget[720] height[1280]
04-14 03:25:17.780+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 33
04-14 03:25:17.780+0900 E/APP_CORE( 8774): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-14 03:25:17.780+0900 I/CAPI_APPFW_APPLICATION( 8774): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:17.780+0900 I/CAPI_APPFW_APPLICATION( 8774): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-14 03:25:17.790+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:17.800+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:25:17.800+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:17.800+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:17.800+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:25:17.800+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:25:17.810+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5e00002 FAILED!
04-14 03:25:17.840+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:17.840+0900 E/EFL     ( 8774): eo<8774> lib/eo/eo.c:676 _eo_call_resolve() in elm_win.eo.c:384: func 'elm_obj_win_xwindow_get' (421) could not be resolved for class 'Elm_Naviframe'.
04-14 03:25:17.850+0900 I/ISE_MULTI(  831): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
04-14 03:25:17.860+0900 I/SWIFTKEY(  661): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-14 03:25:17.870+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:17.870+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:17.870+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:17.870+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:17.910+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:17.920+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:17.920+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:17.930+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:17.930+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:17.950+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:25:17.970+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:25:17.970+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:17.970+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:25:17.970+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:25:17.981+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:18.031+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb8711d10]
04-14 03:25:18.031+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:25:18.031+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb8711d10
04-14 03:25:18.031+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:25:18.031+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:25:18.031+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:25:18.031+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:25:18.031+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:25:18.541+0900 E/VCONF   ( 8774): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-14 03:25:18.541+0900 E/VCONF   ( 8774): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-14 03:25:18.571+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8774 pgid = 8774
04-14 03:25:18.571+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(8774)
04-14 03:25:18.611+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:18.611+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:18.611+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:18.611+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 8774
04-14 03:25:18.611+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[8774] terminate event is forwarded
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 8774, ]
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:18.611+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:18.611+0900 I/Tizen::App( 1305): (512) > Not registered pid(8774)
04-14 03:25:18.611+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:18.611+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:18.611+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8774
04-14 03:25:18.621+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:18.621+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 8774.
04-14 03:25:18.831+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5e00002 FAILED!
04-14 03:25:19.552+0900 E/PKGMGR_SERVER( 9092): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:19.552+0900 E/PKGMGR_SERVER( 9092): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:21.834+0900 E/PKGMGR  ( 9185): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-14 03:25:21.914+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:25:21.964+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-14 03:25:21.974+0900 E/PKGMGR_SERVER( 9187): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-14 03:25:21.974+0900 E/PKGMGR  ( 9185): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[91850002]
04-14 03:25:22.125+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-14 03:25:22.125+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-14 03:25:22.135+0900 W/AUL_AMD (  616): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-14 03:25:22.145+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-14 03:25:22.145+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [30]
04-14 03:25:22.145+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-14 03:25:22.315+0900 W/CERT_SVC_VCORE( 9190): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-14 03:25:22.415+0900 E/rpm-installer( 9190): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-14 03:25:22.415+0900 E/rpm-installer( 9190): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-14 03:25:22.465+0900 E/PKGMGR_PARSER( 9190): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-CLIENT( 9190): SocketClient.cpp: SocketClient(37) > Client created
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-CLIENT( 9190): SocketClient.cpp: connect(62) > Client connected
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-SERVER(  910): SocketService.cpp: mainloop(230) > Got incoming connection
04-14 03:25:22.485+0900 I/PRIVACY-MANAGER-CLIENT( 9190): SocketClient.cpp: disconnect(72) > Client disconnected
04-14 03:25:22.495+0900 E/PKGMGR_CERT( 9190): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-14 03:25:22.495+0900 E/PKGMGR_CERT( 9190): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-14 03:25:22.505+0900 E/PKGMGR_CERT( 9190): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-14 03:25:22.535+0900 E/rpm-installer( 9190): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-14 03:25:22.535+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-14 03:25:22.545+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-14 03:25:22.545+0900 E/ESD     (  895): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-14 03:25:22.545+0900 W/AUL_AMD (  616): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-14 03:25:22.545+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-14 03:25:22.555+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-14 03:25:22.765+0900 W/AUL_AMD (  616): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-14 03:25:22.765+0900 W/AUL_AMD (  616): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-14 03:25:24.307+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9190]
04-14 03:25:24.557+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:24.557+0900 E/PKGMGR_SERVER( 9187): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:25.158+0900 E/PKGMGR  ( 9239): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-14 03:25:25.238+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:25:25.288+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-14 03:25:25.298+0900 E/PKGMGR_INFO( 9241): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-14 03:25:25.308+0900 E/rpm-installer( 9241): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-14 03:25:25.308+0900 E/PKGMGR_SERVER( 9241): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-14 03:25:25.318+0900 E/PKGMGR  ( 9239): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[92390002]
04-14 03:25:25.438+0900 E/PKGMGR_INSTALLER( 9244): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-14 03:25:25.438+0900 E/rpm-installer( 9244): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-14 03:25:25.448+0900 E/rpm-installer( 9244): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-14 03:25:25.448+0900 E/rpm-installer( 9244): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-14 03:25:25.498+0900 W/CERT_SVC_VCORE( 9244): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-14 03:25:25.548+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-14 03:25:25.548+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-14 03:25:25.558+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-14 03:25:25.558+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [30]
04-14 03:25:25.558+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-14 03:25:25.818+0900 E/rpm-installer( 9244): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-14 03:25:25.828+0900 E/PKGMGR_PARSER( 9244): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-14 03:25:25.828+0900 E/PKGMGR_PARSER( 9244): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-14 03:25:25.868+0900 I/PRIVACY-MANAGER-CLIENT( 9244): SocketClient.cpp: SocketClient(37) > Client created
04-14 03:25:26.068+0900 E/PKGMGR_PARSER( 9244): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
04-14 03:25:26.088+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-14 03:25:26.098+0900 E/PKGMGR_CERT( 9244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-14 03:25:26.098+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-14 03:25:26.098+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [60]
04-14 03:25:26.098+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-14 03:25:26.118+0900 E/rpm-installer( 9244): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-14 03:25:26.138+0900 E/rpm-installer( 9244): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-14 03:25:26.138+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-14 03:25:26.138+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [100]
04-14 03:25:26.138+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-14 03:25:27.560+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-14 03:25:28.020+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-14 03:25:28.020+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-14 03:25:28.020+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-14 03:25:28.020+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-14 03:25:28.020+0900 I/Tizen::App( 1305): (78) > Installation is Completed. [Package = org.example.client]
04-14 03:25:28.020+0900 I/Tizen::App( 1305): (671) > Enter. package(org.example.client), installationResult(0)
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-14 03:25:28.040+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-14 03:25:28.050+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-14 03:25:28.050+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-14 03:25:28.050+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-14 03:25:28.060+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-14 03:25:28.060+0900 I/Tizen::App( 1305): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-14 03:25:28.060+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-14 03:25:28.070+0900 I/Tizen::App( 1305): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:25:28.080+0900 E/PKGMGR_INFO( 1305): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (683) > Application count(1) in this package
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (840) > Enter.
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (703) > Exit.
04-14 03:25:28.080+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-14 03:25:28.090+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-14 03:25:28.090+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9244]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-14 03:25:28.100+0900 I/Tizen::App( 1305): (131) > Enter
04-14 03:25:28.110+0900 I/Tizen::App( 1305): (137) > org.example.client does not have launch condition
04-14 03:25:28.110+0900 I/Tizen::App( 1305): (883) > Exit.
04-14 03:25:28.120+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-14 03:25:29.552+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:25:29.552+0900 E/PKGMGR_SERVER( 9241): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:25:32.244+0900 W/AUL     ( 9298): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-14 03:25:32.244+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 0
04-14 03:25:32.254+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-14 03:25:32.264+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-14 03:25:32.264+0900 E/AUL_AMD (  616): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-14 03:25:32.264+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 9298
04-14 03:25:32.264+0900 E/AUL_AMD (  616): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-14 03:25:32.264+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:25:32.264+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:25:32.274+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:25:32.274+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:25:32.274+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:25:32.284+0900 I/abc     ( 9035): abc
04-14 03:25:32.284+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:25:32.284+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:25:32.314+0900 E/TBM     ( 9035): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:25:32.375+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9035, appid: org.example.client
04-14 03:25:32.375+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:25:32.385+0900 W/AUL     ( 9298): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9035)
04-14 03:25:32.595+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(514) > [APP 9035] Event: RESET State: CREATED
04-14 03:25:32.595+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:25:32.605+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.605+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.615+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.615+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.615+0900 E/EFL     ( 9035): edje<9035> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:25:32.615+0900 E/EFL     ( 9035): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:25:32.625+0900 W/APP_CORE( 9035): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
04-14 03:25:32.625+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:25:32.635+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:32.635+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:32.645+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:25:32.645+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:32.655+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:32.665+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:25:32.745+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:25:32.745+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:25:32.745+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(514) > [APP 9035] Event: RESUME State: CREATED
04-14 03:25:32.745+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:25:32.745+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:25:32.745+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9035) status(3)
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:32.745+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:32.745+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9035)
04-14 03:25:32.745+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9035, appid: org.example.client, status: fg
04-14 03:25:32.755+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:25:32.755+0900 I/APP_CORE( 9035): appcore-efl.c: __do_app(625) > [APP 9035] Initial Launching, call the resume_cb
04-14 03:25:32.755+0900 I/CAPI_APPFW_APPLICATION( 9035): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:32.765+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:25:32.765+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:25:32.765+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:25:33.105+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9035) status(0)
04-14 03:25:33.436+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:25:33.436+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:33.446+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.678
04-14 03:25:33.956+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28861401
04-14 03:25:34.046+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28861489
04-14 03:25:34.206+0900 I/UXT     ( 9311): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:25:34.346+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28861797
04-14 03:25:34.356+0900 I/MY_LOG  ( 9035): Button pressed
04-14 03:25:34.437+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28861885
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9035) : db/ise/keysound error
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:25:34.447+0900 E/VCONF   ( 9035): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:25:34.497+0900 I/MY_LOG  ( 9035): Button unpressed
04-14 03:25:35.157+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28862598
04-14 03:25:35.157+0900 I/MY_LOG  ( 9035): Button pressed
04-14 03:25:35.257+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28862697
04-14 03:25:35.267+0900 I/MY_LOG  ( 9035): Button unpressed
04-14 03:25:35.297+0900 D/basicui ( 9035): successed to load edc file
04-14 03:25:36.789+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28864235
04-14 03:25:36.879+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28864323
04-14 03:25:36.909+0900 D/basicui ( 9035): successed to load edc file
04-14 03:25:36.939+0900 I/MY_LOG  ( 9035): change
04-14 03:25:37.009+0900 I/MY_LOG  ( 9035): change
04-14 03:25:37.750+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:25:38.440+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28865888
04-14 03:25:39.381+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28866826
04-14 03:25:39.722+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28867164
04-14 03:25:40.162+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=28867605
04-14 03:25:40.402+0900 E/EFL     ( 9035): ecore_x<9035> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=28867848
04-14 03:25:40.543+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9035 pgid = 9035
04-14 03:25:40.543+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9035)
04-14 03:25:40.553+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:25:40.563+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:25:40.563+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:25:40.563+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:25:40.593+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:25:40.593+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:25:40.593+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:25:40.593+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9035
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9035] terminate event is forwarded
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9035, ]
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:25:40.593+0900 I/Tizen::App( 1305): (512) > Not registered pid(9035)
04-14 03:25:40.593+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:25:40.593+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9035
04-14 03:25:40.593+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9035
04-14 03:25:40.603+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.682
04-14 03:25:40.613+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:25:40.623+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:25:40.623+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9035.
04-14 03:25:40.643+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:25:40.643+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:25:40.643+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:25:40.643+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:25:40.653+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:25:40.673+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:25:40.673+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:25:40.693+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:25:40.693+0900 W/CRASH_MANAGER( 9317): worker.c: worker_job(1199) > 1109035636c69149210794
